﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Y2_ADMS_Event_Integ_MidtermProj_PetShopInventory
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PetChest")]
	public partial class PetChestConnDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertLog(Log instance);
    partial void UpdateLog(Log instance);
    partial void DeleteLog(Log instance);
    #endregion
		
		public PetChestConnDataContext() : 
				base(global::Y2_ADMS_Event_Integ_MidtermProj_PetShopInventory.Properties.Settings.Default.PetChestConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public PetChestConnDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PetChestConnDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PetChestConnDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PetChestConnDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employeeDisplay> employeeDisplays
		{
			get
			{
				return this.GetTable<employeeDisplay>();
			}
		}
		
		public System.Data.Linq.Table<medicalDisplay> medicalDisplays
		{
			get
			{
				return this.GetTable<medicalDisplay>();
			}
		}
		
		public System.Data.Linq.Table<petDisplay> petDisplays
		{
			get
			{
				return this.GetTable<petDisplay>();
			}
		}
		
		public System.Data.Linq.Table<productDisplay> productDisplays
		{
			get
			{
				return this.GetTable<productDisplay>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Log> Logs
		{
			get
			{
				return this.GetTable<Log>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.addMedSum")]
		public int addMedSum([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_ID", DbType="Int")] System.Nullable<int> pet_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Physical_Exam", DbType="VarChar(50)")] string physical_Exam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecal_Test", DbType="VarChar(50)")] string fecal_Test, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Blood_Test", DbType="VarChar(50)")] string blood_Test, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Parasite_Exam", DbType="VarChar(50)")] string parasite_Exam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Last_Checkup", DbType="VarChar(50)")] string last_Checkup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pet_ID, physical_Exam, fecal_Test, blood_Test, parasite_Exam, last_Checkup);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.addPet")]
		public int addPet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Name", DbType="VarChar(50)")] string pet_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetType_ID", DbType="VarChar(50)")] string petType_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Breed", DbType="VarChar(50)")] string pet_Breed, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Age", DbType="Int")] System.Nullable<int> pet_Age, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Sex", DbType="VarChar(50)")] string pet_Sex, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Price", DbType="Int")] System.Nullable<int> pet_Price, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetStatus_ID", DbType="VarChar(50)")] string petStatus_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pet_Name, petType_ID, pet_Breed, pet_Age, pet_Sex, pet_Price, petStatus_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.addProduct")]
		public int addProduct([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_Name", DbType="VarChar(50)")] string product_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetType_ID", DbType="VarChar(50)")] string petType_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductType_ID", DbType="VarChar(50)")] string productType_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_Stock", DbType="Int")] System.Nullable<int> product_Stock, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_Price", DbType="Int")] System.Nullable<int> product_Price)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), product_Name, petType_ID, productType_ID, product_Stock, product_Price);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.updateMedSum")]
		public int updateMedSum([global::System.Data.Linq.Mapping.ParameterAttribute(Name="MedSum_ID", DbType="Int")] System.Nullable<int> medSum_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Physical_Exam", DbType="VarChar(50)")] string physical_Exam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Fecal_Test", DbType="VarChar(50)")] string fecal_Test, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Blood_Test", DbType="VarChar(50)")] string blood_Test, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Parasite_Exam", DbType="VarChar(50)")] string parasite_Exam, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Last_Checkup", DbType="VarChar(50)")] string last_Checkup)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), medSum_ID, physical_Exam, fecal_Test, blood_Test, parasite_Exam, last_Checkup);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.updatePets")]
		public int updatePets([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_ID", DbType="Int")] System.Nullable<int> pet_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Name", DbType="VarChar(50)")] string pet_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetType_ID", DbType="VarChar(50)")] string petType_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Breed", DbType="VarChar(50)")] string pet_Breed, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Age", DbType="Int")] System.Nullable<int> pet_Age, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Sex", DbType="VarChar(50)")] string pet_Sex, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pet_Price", DbType="Int")] System.Nullable<int> pet_Price, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetStatus_ID", DbType="VarChar(50)")] string petStatus_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), pet_ID, pet_Name, petType_ID, pet_Breed, pet_Age, pet_Sex, pet_Price, petStatus_ID);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.updateProducts")]
		public int updateProducts([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_ID", DbType="Int")] System.Nullable<int> product_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_Name", DbType="VarChar(50)")] string product_Name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetType_ID", DbType="VarChar(50)")] string petType_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductType_ID", DbType="VarChar(50)")] string productType_ID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_Stock", DbType="Int")] System.Nullable<int> product_Stock, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Product_Price", DbType="Int")] System.Nullable<int> product_Price)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), product_ID, product_Name, petType_ID, productType_ID, product_Stock, product_Price);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employeeDisplay")]
	public partial class employeeDisplay
	{
		
		private string _Employee_ID;
		
		private string _Employee_Name;
		
		private string _Employee_Email;
		
		private string _Employee_Role;
		
		private string _Employee_Status;
		
		private System.DateTime _Last_Login;
		
		public employeeDisplay()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this._Employee_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_Name
		{
			get
			{
				return this._Employee_Name;
			}
			set
			{
				if ((this._Employee_Name != value))
				{
					this._Employee_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_Email
		{
			get
			{
				return this._Employee_Email;
			}
			set
			{
				if ((this._Employee_Email != value))
				{
					this._Employee_Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Role", DbType="VarChar(50)")]
		public string Employee_Role
		{
			get
			{
				return this._Employee_Role;
			}
			set
			{
				if ((this._Employee_Role != value))
				{
					this._Employee_Role = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Status", DbType="VarChar(50)")]
		public string Employee_Status
		{
			get
			{
				return this._Employee_Status;
			}
			set
			{
				if ((this._Employee_Status != value))
				{
					this._Employee_Status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Login", DbType="DateTime NOT NULL")]
		public System.DateTime Last_Login
		{
			get
			{
				return this._Last_Login;
			}
			set
			{
				if ((this._Last_Login != value))
				{
					this._Last_Login = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.medicalDisplay")]
	public partial class medicalDisplay
	{
		
		private int _MedSum_ID;
		
		private string _Pet_Name;
		
		private string _Physical_Exam;
		
		private string _Fecal_Test;
		
		private string _Blood_Test;
		
		private string _Parasite_Exam;
		
		private string _Last_Checkup;
		
		public medicalDisplay()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedSum_ID", DbType="Int NOT NULL")]
		public int MedSum_ID
		{
			get
			{
				return this._MedSum_ID;
			}
			set
			{
				if ((this._MedSum_ID != value))
				{
					this._MedSum_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Name", DbType="VarChar(50)")]
		public string Pet_Name
		{
			get
			{
				return this._Pet_Name;
			}
			set
			{
				if ((this._Pet_Name != value))
				{
					this._Pet_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Physical_Exam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Physical_Exam
		{
			get
			{
				return this._Physical_Exam;
			}
			set
			{
				if ((this._Physical_Exam != value))
				{
					this._Physical_Exam = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecal_Test", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Fecal_Test
		{
			get
			{
				return this._Fecal_Test;
			}
			set
			{
				if ((this._Fecal_Test != value))
				{
					this._Fecal_Test = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Blood_Test", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Blood_Test
		{
			get
			{
				return this._Blood_Test;
			}
			set
			{
				if ((this._Blood_Test != value))
				{
					this._Blood_Test = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Parasite_Exam", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Parasite_Exam
		{
			get
			{
				return this._Parasite_Exam;
			}
			set
			{
				if ((this._Parasite_Exam != value))
				{
					this._Parasite_Exam = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Checkup", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Last_Checkup
		{
			get
			{
				return this._Last_Checkup;
			}
			set
			{
				if ((this._Last_Checkup != value))
				{
					this._Last_Checkup = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.petDisplay")]
	public partial class petDisplay
	{
		
		private int _Pet_ID;
		
		private string _Pet_Name;
		
		private string _Pet_Type;
		
		private string _Pet_Breed;
		
		private int _Pet_Age;
		
		private string _Pet_Sex;
		
		private int _Pet_Price;
		
		private string _Pet_Status;
		
		public petDisplay()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_ID", DbType="Int NOT NULL")]
		public int Pet_ID
		{
			get
			{
				return this._Pet_ID;
			}
			set
			{
				if ((this._Pet_ID != value))
				{
					this._Pet_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pet_Name
		{
			get
			{
				return this._Pet_Name;
			}
			set
			{
				if ((this._Pet_Name != value))
				{
					this._Pet_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Type", DbType="VarChar(50)")]
		public string Pet_Type
		{
			get
			{
				return this._Pet_Type;
			}
			set
			{
				if ((this._Pet_Type != value))
				{
					this._Pet_Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Breed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pet_Breed
		{
			get
			{
				return this._Pet_Breed;
			}
			set
			{
				if ((this._Pet_Breed != value))
				{
					this._Pet_Breed = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Age", DbType="Int NOT NULL")]
		public int Pet_Age
		{
			get
			{
				return this._Pet_Age;
			}
			set
			{
				if ((this._Pet_Age != value))
				{
					this._Pet_Age = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Sex", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pet_Sex
		{
			get
			{
				return this._Pet_Sex;
			}
			set
			{
				if ((this._Pet_Sex != value))
				{
					this._Pet_Sex = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Price", DbType="Int NOT NULL")]
		public int Pet_Price
		{
			get
			{
				return this._Pet_Price;
			}
			set
			{
				if ((this._Pet_Price != value))
				{
					this._Pet_Price = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Status", DbType="VarChar(50)")]
		public string Pet_Status
		{
			get
			{
				return this._Pet_Status;
			}
			set
			{
				if ((this._Pet_Status != value))
				{
					this._Pet_Status = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.productDisplay")]
	public partial class productDisplay
	{
		
		private int _Product_ID;
		
		private string _Product_Name;
		
		private string _Pet_Type;
		
		private string _Product_Type;
		
		private int _Product_Stock;
		
		private int _Product_Price;
		
		public productDisplay()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_ID", DbType="Int NOT NULL")]
		public int Product_ID
		{
			get
			{
				return this._Product_ID;
			}
			set
			{
				if ((this._Product_ID != value))
				{
					this._Product_ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Product_Name
		{
			get
			{
				return this._Product_Name;
			}
			set
			{
				if ((this._Product_Name != value))
				{
					this._Product_Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pet_Type", DbType="VarChar(50)")]
		public string Pet_Type
		{
			get
			{
				return this._Pet_Type;
			}
			set
			{
				if ((this._Pet_Type != value))
				{
					this._Pet_Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Type", DbType="VarChar(50)")]
		public string Product_Type
		{
			get
			{
				return this._Product_Type;
			}
			set
			{
				if ((this._Product_Type != value))
				{
					this._Product_Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Stock", DbType="Int NOT NULL")]
		public int Product_Stock
		{
			get
			{
				return this._Product_Stock;
			}
			set
			{
				if ((this._Product_Stock != value))
				{
					this._Product_Stock = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Product_Price", DbType="Int NOT NULL")]
		public int Product_Price
		{
			get
			{
				return this._Product_Price;
			}
			set
			{
				if ((this._Product_Price != value))
				{
					this._Product_Price = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Employee_ID;
		
		private string _Employee_Name;
		
		private string _Employee_Email;
		
		private string _Employee_Password;
		
		private string _EmployeeRole_ID;
		
		private string _EmployeeStatus_ID;
		
		private System.DateTime _Last_Login;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployee_IDChanging(string value);
    partial void OnEmployee_IDChanged();
    partial void OnEmployee_NameChanging(string value);
    partial void OnEmployee_NameChanged();
    partial void OnEmployee_EmailChanging(string value);
    partial void OnEmployee_EmailChanged();
    partial void OnEmployee_PasswordChanging(string value);
    partial void OnEmployee_PasswordChanged();
    partial void OnEmployeeRole_IDChanging(string value);
    partial void OnEmployeeRole_IDChanged();
    partial void OnEmployeeStatus_IDChanging(string value);
    partial void OnEmployeeStatus_IDChanged();
    partial void OnLast_LoginChanging(System.DateTime value);
    partial void OnLast_LoginChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this.OnEmployee_IDChanging(value);
					this.SendPropertyChanging();
					this._Employee_ID = value;
					this.SendPropertyChanged("Employee_ID");
					this.OnEmployee_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_Name
		{
			get
			{
				return this._Employee_Name;
			}
			set
			{
				if ((this._Employee_Name != value))
				{
					this.OnEmployee_NameChanging(value);
					this.SendPropertyChanging();
					this._Employee_Name = value;
					this.SendPropertyChanged("Employee_Name");
					this.OnEmployee_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_Email
		{
			get
			{
				return this._Employee_Email;
			}
			set
			{
				if ((this._Employee_Email != value))
				{
					this.OnEmployee_EmailChanging(value);
					this.SendPropertyChanging();
					this._Employee_Email = value;
					this.SendPropertyChanged("Employee_Email");
					this.OnEmployee_EmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Employee_Password
		{
			get
			{
				return this._Employee_Password;
			}
			set
			{
				if ((this._Employee_Password != value))
				{
					this.OnEmployee_PasswordChanging(value);
					this.SendPropertyChanging();
					this._Employee_Password = value;
					this.SendPropertyChanged("Employee_Password");
					this.OnEmployee_PasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeRole_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmployeeRole_ID
		{
			get
			{
				return this._EmployeeRole_ID;
			}
			set
			{
				if ((this._EmployeeRole_ID != value))
				{
					this.OnEmployeeRole_IDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeRole_ID = value;
					this.SendPropertyChanged("EmployeeRole_ID");
					this.OnEmployeeRole_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeStatus_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmployeeStatus_ID
		{
			get
			{
				return this._EmployeeStatus_ID;
			}
			set
			{
				if ((this._EmployeeStatus_ID != value))
				{
					this.OnEmployeeStatus_IDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeStatus_ID = value;
					this.SendPropertyChanged("EmployeeStatus_ID");
					this.OnEmployeeStatus_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Login", DbType="DateTime NOT NULL")]
		public System.DateTime Last_Login
		{
			get
			{
				return this._Last_Login;
			}
			set
			{
				if ((this._Last_Login != value))
				{
					this.OnLast_LoginChanging(value);
					this.SendPropertyChanging();
					this._Last_Login = value;
					this.SendPropertyChanged("Last_Login");
					this.OnLast_LoginChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Logs")]
	public partial class Log : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Log_ID;
		
		private string _Login_ID;
		
		private System.DateTime _Login_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLog_IDChanging(int value);
    partial void OnLog_IDChanged();
    partial void OnLogin_IDChanging(string value);
    partial void OnLogin_IDChanged();
    partial void OnLogin_DateChanging(System.DateTime value);
    partial void OnLogin_DateChanged();
    #endregion
		
		public Log()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Log_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Log_ID
		{
			get
			{
				return this._Log_ID;
			}
			set
			{
				if ((this._Log_ID != value))
				{
					this.OnLog_IDChanging(value);
					this.SendPropertyChanging();
					this._Log_ID = value;
					this.SendPropertyChanged("Log_ID");
					this.OnLog_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Login_ID
		{
			get
			{
				return this._Login_ID;
			}
			set
			{
				if ((this._Login_ID != value))
				{
					this.OnLogin_IDChanging(value);
					this.SendPropertyChanging();
					this._Login_ID = value;
					this.SendPropertyChanged("Login_ID");
					this.OnLogin_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Login_Date
		{
			get
			{
				return this._Login_Date;
			}
			set
			{
				if ((this._Login_Date != value))
				{
					this.OnLogin_DateChanging(value);
					this.SendPropertyChanging();
					this._Login_Date = value;
					this.SendPropertyChanged("Login_Date");
					this.OnLogin_DateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
