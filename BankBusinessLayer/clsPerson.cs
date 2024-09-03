﻿using BankBusinessLayer.Properties;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using BankDAL;
using System.IO;
using System.Drawing.Imaging;
using ImageProcessing;

namespace BankBusinessLayer
{
    public enum enMode {AddNew, Update}

    public enum enRole{User, Client}

    public enum enSex{Male = 1, Female}

    public class clsPhone
    {
        private enMode _Mode;

        private int _ID;
        private int _PersonID;
        public int ID { get { return _ID; } }

        public int PersonID { get { return _PersonID; } }

        public string Value { get; set; }

        public bool DeleteMark { get; set; }

        private bool _Add()
        {
            _ID = clsPhonesDA.AddNewWith(PersonID, Value);
            return _ID != -1;
        }

        private bool _Update()
        {
            return clsPhonesDA.UpdateByID(ID, PersonID, Value);
        }

        private void _ObjPreparer(int ID = -1, int PersonID = -1, string Value = "")
        {
            _ID = ID;
            _PersonID = PersonID;
            this.Value = Value;
            DeleteMark = false;
        }

        public clsPhone()
        {
            _Mode = enMode.AddNew;
            _ObjPreparer();
            
        }

        public clsPhone(int personID, string value)
        {
            _Mode = enMode.AddNew;
            _ObjPreparer(PersonID: personID, Value: value);
        }

        private clsPhone(int ID, int PersonID, string value)
        {
            _Mode = enMode.Update;
            _ID = ID;
            _PersonID = PersonID;
            Value = value;
        }

        internal static bool Delete(int PhoneID)
        {
            return clsPhonesDA.DeleteByID(PhoneID);
        }

        public bool Save()
        {
            bool SaveState = false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (SaveState = _Add())
                    {
                        _Mode = enMode.Update;
                    }
                        break;
                case enMode.Update:
                    return _Update();
            }

            return SaveState;
        }

        public static List<clsPhone> GetAllPhonesFor(int PersonID)
        {
            DataTable phones = clsPhonesDA.GetAllPhonesWith(PersonID);
            List<clsPhone> PhonesLst = new List<clsPhone>();

            foreach(DataRow row in phones.Rows)
            {
                PhonesLst.Add(new clsPhone((int)row["PhoneID"], PersonID, row["Phone"].ToString()));
            }

            return PhonesLst;
        }

        public static bool DoesExistIn(List<clsPhone> phones, string PhoneNum)
        {
            foreach (clsPhone ph in phones)
            {
                if (ph.Value == PhoneNum)
                {
                    return true;    
                }
            }
            return false;
        }
        public override string ToString()
        {
            return Value;
        }

    }

    public abstract class clsPerson 
    {
        public readonly static Color MALE_COLOR = Color.FromArgb(94, 148, 255);
        public readonly static Color FEMALE_COLOR = Color.FromArgb(255, 128, 255);

        private enMode _Mode;

        private static string _AppImagesPath = AppGlobals.AppDataPath + @"\PFPS";

        protected int _PersonID = -1;

        protected enSex _sex;
        
        protected string _ImagePath;

        protected Image _PImage;

        private bool _IsImageModified = false;


        public int PersonID { get { return _PersonID; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {get{ return FirstName + " " + LastName; } }
        public enSex Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
            }
        }
        public string Email { get; set; }
        public string Address { get; set; }
        public Image PImage
        {
            get
            {
                if (_PImage == null)
                {
                    switch (GetRole(PersonID))
                    {
                        case enRole.User:
                            return Resources._User;
                        case enRole.Client:
                            return Resources.Client;
                    }
                }

                return _PImage;
            }

            set
            {
                _IsImageModified = true;
                if (value == null)
                {
                    _ImagePath = string.Empty;
                }
                else
                {
                    _ImagePath = _AppImagesPath + $@"\{PersonID}HQ.{_PImage.RawFormat}";
                }
                _PImage = value;
                ProfilePicChanged?.Invoke(value);
            }
        }
        public bool HasImage { get{ return _PImage != null; } }
        public List<clsPhone> Phones { get; set; }

        public delegate void ProfilePicHandler(Image ProfileImage);

        public event ProfilePicHandler ProfilePicChanged;

        public delegate void SexChangeHandler(enSex sex);

        public event SexChangeHandler SexChanged;

        private bool _Add()
        {

            _PersonID = clsPersonDA.AddNewWith(FirstName, LastName, (byte)Sex, Email, Address, _ImagePath);
            bool CreateState = _PersonID != -1 ;

            if (CreateState)
            {
                clsUserActionLogger.AddAction(AppGlobals.SysUser.ID, PersonID, enUserActions.Create);
                ImageHandler.SaveImage(_PImage, _ImagePath);
            }
            return CreateState;
        }

        private bool _Update()
        {
            bool UpdateState = clsPersonDA.UpdateByID(PersonID, FirstName, LastName, (byte)Sex, Email, Address, _ImagePath);

            if (UpdateState)
            {
                clsUserActionLogger.AddAction(AppGlobals.SysUser.ID, PersonID, enUserActions.Update);

                if (_IsImageModified)
                    ImageHandler.SaveImage(_PImage, _ImagePath);
            }

            return UpdateState;
        }

        private bool _SavePhones()
        {
            foreach (clsPhone phone in Phones)
            {
                if (phone.DeleteMark)
                {
                    if (phone.ID != -1)
                        clsPhonesDA.DeleteByID(phone.ID);

                    continue;
                }
                if (!phone.Save())
                {
                    return false;
                }
            }
            return true;
        }

        private void _ObjPreparer(int ID = -1, string FirstName = "", string LastName = "", byte Sex = 0, string Email = "", string Address = "", Image Pfp = null)
        {
            _PersonID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Sex = (enSex)Sex;
            this.Email = Email;
            this.Address = Address;
            this.PImage = Pfp;

            if (ID == -1)
                Phones = new List<clsPhone>();
            else
                Phones = clsPhone.GetAllPhonesFor(ID);
        }

        static clsPerson()
        {
            if(!Directory.Exists(_AppImagesPath)) Directory.CreateDirectory(_AppImagesPath);
        }

        protected clsPerson()
        {
            _Mode = enMode.AddNew;
            _ObjPreparer();
        }

        protected clsPerson(string firstName, string lastName, byte sex, string email, string address, Image Pfp)
        {
            _Mode = enMode.AddNew;
            
            _ObjPreparer(-1, firstName, lastName, sex, email, address, Pfp);
        }

        protected clsPerson( int iD, string firstName, string lastName, byte sex, string email,string address, Image Pfp)
        {
            _Mode = enMode.Update;
            
            _ObjPreparer(iD, firstName, lastName, sex, email, address, Pfp);
        }

        public clsPhone AddPhone(string PhoneNumber)
        {
            clsPhone NewPhone = new clsPhone(PersonID, PhoneNumber);
            Phones.Add(NewPhone);
            return NewPhone;
        }

        //public static bool DoesExist(int PersonID)
        //{
        //    return clsPersonDA.DoesExist(PersonID);
        //}

        public static bool Delete(int PersonID)
        {
            bool DeleteState = clsPersonDA.DeleteByID(PersonID);

            if (DeleteState)
            {
                clsUserActionLogger.AddAction(AppGlobals.SysUser.ID, PersonID, enUserActions.Delete);

                string Extension = "", ImagePath = _AppImagesPath + $@"\{PersonID}HQ";

                if (File.Exists(ImagePath))
                {
                    Extension = Path.GetExtension(ImagePath);
                    ImagePath += $@".{Extension}";
                }

                ImageHandler.DeleteImage(ImagePath);
            }

            return DeleteState ;
        }

        public virtual bool Save()
        {

            bool SaveState = false;
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (SaveState = _Add())
                    {
                        _Mode = enMode.Update;
                    }
                    break;
                case enMode.Update:
                    SaveState = _Update();
                    break;
            }

            SaveState = _SavePhones();

            if(SaveState) _IsImageModified = false;
        
            return SaveState;
        }

        public string GetSex()
        {
            return Sex.ToString();
        }

        public static enRole GetRole(int PersonID)
        {
            if (clsUserDA.DoesExistByPersonID(PersonID))
            {
                return enRole.User;
            }

            return enRole.Client;
        }



        //public void Find(int PersonID)
        //{
        //    string FirstName = "", LastName = "", Email = "", ImagePath = "";

        //    if (clsPersonDA.GetByID(PersonID, ref FirstName, ref LastName, ref Email, ref ImagePath))
        //    {
        //        _ObjPreparer(PersonID, FirstName, LastName, Email, ImagePath);
        //    }
        //}
    }
}
