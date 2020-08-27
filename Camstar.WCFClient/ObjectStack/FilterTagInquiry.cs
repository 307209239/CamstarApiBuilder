// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTagInquiry
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
  public class FilterTagInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_EmployeeSessionFilterTag")]
    protected Camstar.WCF.ObjectStack.FilterTag[] _EmployeeSessionFilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_FilterTagAccess")]
    protected Enumeration<FilterTagAccessEnum, int> _FilterTagAccess;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_FilterTag")]
    protected Camstar.WCF.ObjectStack.FilterTag[] _FilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_AssignableFilterTag")]
    protected NamedObjectRef[] _AssignableFilterTag;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagInquiry_CurrentEmployee")]
    protected NamedObjectRef _CurrentEmployee;

    public override bool Equals(object obj)
    {
      return obj is FilterTagInquiry && this.CompareArrays((Array) this._EmployeeSessionFilterTag, (Array) ((FilterTagInquiry) obj)._EmployeeSessionFilterTag) && (object.Equals((object) this._FilterTagAccess, (object) ((FilterTagInquiry) obj)._FilterTagAccess) && this.CompareArrays((Array) this._FilterTag, (Array) ((FilterTagInquiry) obj)._FilterTag)) && (this.CompareArrays((Array) this._AssignableFilterTag, (Array) ((FilterTagInquiry) obj)._AssignableFilterTag) && object.Equals((object) this._CurrentEmployee, (object) ((FilterTagInquiry) obj)._CurrentEmployee)) && base.Equals(obj);
    }

    public Camstar.WCF.ObjectStack.FilterTag[] EmployeeSessionFilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeSessionFilterTag), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.FilterTag[]) this.PropertyGet(nameof (EmployeeSessionFilterTag));
      }
    }

    public Enumeration<FilterTagAccessEnum, int> FilterTagAccess
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTagAccess), (object) value);
      }
      get
      {
        return (Enumeration<FilterTagAccessEnum, int>) this.PropertyGet(nameof (FilterTagAccess));
      }
    }

    public Camstar.WCF.ObjectStack.FilterTag[] FilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTag), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.FilterTag[]) this.PropertyGet(nameof (FilterTag));
      }
    }

    public NamedObjectRef[] AssignableFilterTag
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignableFilterTag), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (AssignableFilterTag));
      }
    }

    public NamedObjectRef CurrentEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CurrentEmployee));
      }
    }
  }
}
