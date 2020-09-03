using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;



namespace Leave_Management_System

{

    class Leave

    {
        static List<Leave> list = new List<Leave>();
        private int _leaveId;

        private int _empId;

        private DateTime _leaveFrom;

        private DateTime _leaveTo;

        private int _leaveNdays;

        private DateTime _leaveApplyDate;

        private string _leaveType;

        private string _leaveReason;

        private string _lStatus;


        public Leave()

        {



        }



        public Leave(int leaveId, int empId, DateTime leaveFrom, DateTime leaveTo, int leaveNdays, DateTime leaveApplyDate,

            string leaveType, string leaveReason, string lStatus)

        {

            this._leaveId = leaveId;

            this._empId = empId;

            this._leaveFrom = leaveFrom;

            this._leaveTo = leaveTo;

            this._leaveNdays = leaveNdays;

            this._leaveApplyDate = leaveApplyDate;

            this._leaveType = leaveType;

            this._leaveReason = leaveReason;

            this._lStatus = lStatus;
        }



        public int LeaveId

        {

            get { return this._leaveId; }

            set { this._leaveId = value; }

        }



        public int EmpId

        {

            get { return this._empId; }

            set { this._empId = value; }

        }



        public DateTime LeaveFrom

        {

            get { return this._leaveFrom; }

            set { this._leaveFrom = value; }

        }



        public int LeaveNdays

        {

            get { return this._leaveNdays; }

            set { this._leaveNdays = value; }

        }



        public DateTime LeaveTo

        {

            get { return this._leaveTo; }

            set { this._leaveTo = value; }

        }



        public DateTime LeaveApplyDate

        {

            get { return this._leaveApplyDate; }

            set { this._leaveApplyDate = value; }

        }



        public string LeaveReason

        {

            get { return this._leaveReason; }

            set { this._leaveReason = value; }

        }


        public void add(Leave l)
        {
            list.Add(l);
        }

        public void displayAllLeaves()
        {
            foreach (Leave l in list)
            {
                Console.WriteLine(l.ToString());
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            return "Leave Id:" + _leaveId + "  " + "Employee ID:" + _empId + "  " + "Leave From:" + _leaveFrom + "  " + "Leave to:" + _leaveTo
                + "  " + "No. of Leave Days:" + _leaveNdays + "  " + "Leave Apply date:" + _leaveApplyDate + "  " + "Leave type: " + _leaveType
                + "  " + "Leave Status: " + _lStatus + "  " + "Leave Reason:" + _leaveReason;
        }

    }

}