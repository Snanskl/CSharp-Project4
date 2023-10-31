using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class PartyManager
    {
        #region Fields area
        private string[] guestList;
        private double costPerPerson = 0.0;
        private double feePerPerson = 0.0;
        #endregion

        #region methods area
        public PartyManager(int maxGuests)
        { 
            //Constructor calling an array. This will be called to the user first
            guestList = new string[maxGuests];
        }
        #endregion

        #region get and set area
        public double CostPerPerson
        { 
            get { return costPerPerson; }
            set 
            {
                if (value >= 0.0)
                { costPerPerson = value; }
            }
        }
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set
            {
                if (feePerPerson >= 0.0)
                { feePerPerson = value; }
            }
        }
        #endregion

        #region Manual Methods
        public bool CheckIndex(int fillSrting)
        {
            bool validIndex = false;
            //this function is to check if the index in arr is empty or not
            for (int loop = 0; loop < guestList.Length; loop++)
            {
                if (string.IsNullOrEmpty(guestList[loop]) )
                {guestList[loop] = fillSrting;}
            }
            return validIndex;
        }
        private int FindEmptyPos() // done
        {
            int emptyPos = -1;
            for (int index = 0; index < guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    emptyPos = index;
                    break;
                }
            }
            return emptyPos;
        }
        public bool AddNewGuest(string firstName, string lastName) //done
        {
            bool validAddGuest = false;
            int emptyPos = FindEmptyPos();

            if (emptyPos != -1)
            { 
                guestList[emptyPos] = FullName(firstName, lastName); 
                validAddGuest = true;
            }
            else
            { validAddGuest = false; }

            return validAddGuest;
        }
        public bool DeleteGuestAt(int deleteIndex)
        {
            bool validDelete = false;
            if (CheckIndex(deleteIndex))
            {
                guestList[deleteIndex] = string.Empty;
                MoveElToLeft(deleteIndex);
                validDelete = true;
            }

            return validDelete;
        
        }
        private void MoveElToLeft(int index)
        {
            for (int i = index; i < guestList.Length; i++)
            {

            }
        
        }
        private string FullName(string firstName, string LastName) //done
        { return $"{LastName.ToUpper()}, {firstName}";}

        private int CountingNumOfGuest() //done
        {
            //this function is to keep a count of how many guess in an array
            int numOfGuest = 0;

            for (int loopthrough = 0; loopthrough < guestList.Length; loopthrough++)
            {
                if (guestList[loopthrough] != null && guestList[loopthrough] != string.Empty)
                {
                    numOfGuest++;
                }
            }
            return numOfGuest;
        }
        #endregion

    }
}
