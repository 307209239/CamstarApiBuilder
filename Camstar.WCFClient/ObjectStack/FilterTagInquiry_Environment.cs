// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTagInquiry_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class FilterTagInquiry_Environment : Inquiry_Environment
  {
    [Metadata("Filter Tag CDO", "FilterTag", false, false, false, "FilterTag", 16779324, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Environment_EmployeeSessionFilterTag")]
    protected FilterTag_Environment _EmployeeSessionFilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Environment_FilterTagAccess")]
    [Metadata("Enumeration for FilterAccessType\r\n1 = All\r\n2 = Tagged and Untagged Access\r\n3 = Tagged Access Only", "FilterTagAccessEnum", false, false, false, "Integer", 16779322, false, false, false, null)]
    protected Environment _FilterTagAccess;
    [Metadata("Filter Tag CDO", "FilterTag", false, false, false, "FilterTag", 16778957, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Environment_FilterTag")]
    protected FilterTag_Environment _FilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Environment_AssignableFilterTag")]
    [Metadata("Filter Tag CDO", "FilterTag", false, false, false, "NamedObjectRef", 16779325, false, true, false, null)]
    protected Environment _AssignableFilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Environment_CurrentEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048861, false, false, false, null)]
    protected Environment _CurrentEmployee;

    public FilterTag_Environment EmployeeSessionFilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeSessionFilterTag), (object) value);
      }
      get
      {
        return (FilterTag_Environment) this.PropertyGet(nameof (EmployeeSessionFilterTag));
      }
    }

    public Environment FilterTagAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagAccess), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTagAccess));
      }
    }

    public FilterTag_Environment FilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTag), (object) value);
      }
      get
      {
        return (FilterTag_Environment) this.PropertyGet(nameof (FilterTag));
      }
    }

    public Environment AssignableFilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignableFilterTag), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignableFilterTag));
      }
    }

    public Environment CurrentEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentEmployee));
      }
    }
  }
}
