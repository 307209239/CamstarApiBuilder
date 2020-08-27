// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTagInquiry_Info
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
  public class FilterTagInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Info_EmployeeSessionFilterTag")]
    protected FilterTag_Info _EmployeeSessionFilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Info_FilterTagAccess")]
    protected Info _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Info_FilterTag")]
    protected FilterTag_Info _FilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Info_AssignableFilterTag")]
    protected Info _AssignableFilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_Info_CurrentEmployee")]
    protected Info _CurrentEmployee;

    public FilterTag_Info EmployeeSessionFilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeSessionFilterTag), (object) value);
      }
      get
      {
        return (FilterTag_Info) this.PropertyGet(nameof (EmployeeSessionFilterTag));
      }
    }

    public Info FilterTagAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagAccess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTagAccess));
      }
    }

    public FilterTag_Info FilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTag), (object) value);
      }
      get
      {
        return (FilterTag_Info) this.PropertyGet(nameof (FilterTag));
      }
    }

    public Info AssignableFilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignableFilterTag), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignableFilterTag));
      }
    }

    public Info CurrentEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentEmployee));
      }
    }
  }
}
