﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace SessionManagement
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SessionDbContext : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new SessionDbContext object using the connection string found in the 'SessionDbContext' section of the application configuration file.
        /// </summary>
        public SessionDbContext() : base("name=SessionDbContext", "SessionDbContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SessionDbContext object.
        /// </summary>
        public SessionDbContext(string connectionString) : base(connectionString, "SessionDbContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new SessionDbContext object.
        /// </summary>
        public SessionDbContext(EntityConnection connection) : base(connection, "SessionDbContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_ServerSession> tbl_ServerSession
        {
            get
            {
                if ((_tbl_ServerSession == null))
                {
                    _tbl_ServerSession = base.CreateObjectSet<tbl_ServerSession>("tbl_ServerSession");
                }
                return _tbl_ServerSession;
            }
        }
        private ObjectSet<tbl_ServerSession> _tbl_ServerSession;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_ServerSession EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_ServerSession(tbl_ServerSession tbl_ServerSession)
        {
            base.AddObject("tbl_ServerSession", tbl_ServerSession);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="user_ID">No Metadata Documentation available.</param>
        /// <param name="sessionID">No Metadata Documentation available.</param>
        public int Update_Session(global::System.String user_ID, ObjectParameter sessionID)
        {
            ObjectParameter user_IDParameter;
            if (user_ID != null)
            {
                user_IDParameter = new ObjectParameter("User_ID", user_ID);
            }
            else
            {
                user_IDParameter = new ObjectParameter("User_ID", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("Update_Session", user_IDParameter, sessionID);
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="name">No Metadata Documentation available.</param>
        /// <param name="imagePath">No Metadata Documentation available.</param>
        /// <param name="description">No Metadata Documentation available.</param>
        /// <param name="art_ID">No Metadata Documentation available.</param>
        public int usp_upload_ArtistProfile(global::System.String name, global::System.String imagePath, global::System.String description, ObjectParameter art_ID)
        {
            ObjectParameter nameParameter;
            if (name != null)
            {
                nameParameter = new ObjectParameter("Name", name);
            }
            else
            {
                nameParameter = new ObjectParameter("Name", typeof(global::System.String));
            }
    
            ObjectParameter imagePathParameter;
            if (imagePath != null)
            {
                imagePathParameter = new ObjectParameter("ImagePath", imagePath);
            }
            else
            {
                imagePathParameter = new ObjectParameter("ImagePath", typeof(global::System.String));
            }
    
            ObjectParameter descriptionParameter;
            if (description != null)
            {
                descriptionParameter = new ObjectParameter("Description", description);
            }
            else
            {
                descriptionParameter = new ObjectParameter("Description", typeof(global::System.String));
            }
    
            return base.ExecuteFunction("usp_upload_ArtistProfile", nameParameter, imagePathParameter, descriptionParameter, art_ID);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SessionEF_Model", Name="tbl_ServerSession")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_ServerSession : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_ServerSession object.
        /// </summary>
        /// <param name="session_ID">Initial value of the Session_ID property.</param>
        /// <param name="user_ID">Initial value of the User_ID property.</param>
        public static tbl_ServerSession Createtbl_ServerSession(global::System.Guid session_ID, global::System.Guid user_ID)
        {
            tbl_ServerSession tbl_ServerSession = new tbl_ServerSession();
            tbl_ServerSession.Session_ID = session_ID;
            tbl_ServerSession.User_ID = user_ID;
            return tbl_ServerSession;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Session_ID
        {
            get
            {
                return _Session_ID;
            }
            set
            {
                if (_Session_ID != value)
                {
                    OnSession_IDChanging(value);
                    ReportPropertyChanging("Session_ID");
                    _Session_ID = StructuralObject.SetValidValue(value, "Session_ID");
                    ReportPropertyChanged("Session_ID");
                    OnSession_IDChanged();
                }
            }
        }
        private global::System.Guid _Session_ID;
        partial void OnSession_IDChanging(global::System.Guid value);
        partial void OnSession_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SessionValue
        {
            get
            {
                return _SessionValue;
            }
            set
            {
                OnSessionValueChanging(value);
                ReportPropertyChanging("SessionValue");
                _SessionValue = StructuralObject.SetValidValue(value, true, "SessionValue");
                ReportPropertyChanged("SessionValue");
                OnSessionValueChanged();
            }
        }
        private global::System.String _SessionValue;
        partial void OnSessionValueChanging(global::System.String value);
        partial void OnSessionValueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid User_ID
        {
            get
            {
                return _User_ID;
            }
            set
            {
                OnUser_IDChanging(value);
                ReportPropertyChanging("User_ID");
                _User_ID = StructuralObject.SetValidValue(value, "User_ID");
                ReportPropertyChanged("User_ID");
                OnUser_IDChanged();
            }
        }
        private global::System.Guid _User_ID;
        partial void OnUser_IDChanging(global::System.Guid value);
        partial void OnUser_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Ins_Dt
        {
            get
            {
                return _Ins_Dt;
            }
            set
            {
                OnIns_DtChanging(value);
                ReportPropertyChanging("Ins_Dt");
                _Ins_Dt = StructuralObject.SetValidValue(value, "Ins_Dt");
                ReportPropertyChanged("Ins_Dt");
                OnIns_DtChanged();
            }
        }
        private Nullable<global::System.DateTime> _Ins_Dt;
        partial void OnIns_DtChanging(Nullable<global::System.DateTime> value);
        partial void OnIns_DtChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Up_Dt
        {
            get
            {
                return _Up_Dt;
            }
            set
            {
                OnUp_DtChanging(value);
                ReportPropertyChanging("Up_Dt");
                _Up_Dt = StructuralObject.SetValidValue(value, "Up_Dt");
                ReportPropertyChanged("Up_Dt");
                OnUp_DtChanged();
            }
        }
        private Nullable<global::System.DateTime> _Up_Dt;
        partial void OnUp_DtChanging(Nullable<global::System.DateTime> value);
        partial void OnUp_DtChanged();

        #endregion

    }

    #endregion

}
