﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace MvcDemo2
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MvcDemoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MvcDemoEntities object using the connection string found in the 'MvcDemoEntities' section of the application configuration file.
        /// </summary>
        public MvcDemoEntities() : base("name=MvcDemoEntities", "MvcDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MvcDemoEntities object.
        /// </summary>
        public MvcDemoEntities(string connectionString) : base(connectionString, "MvcDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MvcDemoEntities object.
        /// </summary>
        public MvcDemoEntities(EntityConnection connection) : base(connection, "MvcDemoEntities")
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
        public ObjectSet<Student> Student
        {
            get
            {
                if ((_Student == null))
                {
                    _Student = base.CreateObjectSet<Student>("Student");
                }
                return _Student;
            }
        }
        private ObjectSet<Student> _Student;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Student EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudent(Student student)
        {
            base.AddObject("Student", student);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MvcDemoModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Student CreateStudent(global::System.Int32 id)
        {
            Student student = new Student();
            student.Id = id;
            return student;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                OnDOBChanging(value);
                ReportPropertyChanging("DOB");
                _DOB = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("DOB");
                OnDOBChanged();
            }
        }
        private global::System.String _DOB;
        partial void OnDOBChanging(global::System.String value);
        partial void OnDOBChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private global::System.String _Salary;
        partial void OnSalaryChanging(global::System.String value);
        partial void OnSalaryChanged();

        #endregion
    
    }

    #endregion
    
}
