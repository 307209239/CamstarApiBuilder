// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInquiry
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
  public class CDOInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_ObjectReferences")]
    protected ObjectReferencesInfo _ObjectReferences;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_CDODefId")]
    protected Enumeration<MaintainableObjectEnum, string> _CDODefId;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_ObjectReferencesList")]
    protected ObjectReferencesInfo[] _ObjectReferencesList;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_CDODefName")]
    protected Enumeration<MaintainableObjectEnum, string> _CDODefName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_ObjectsToResolve")]
    protected ObjectToResolve[] _ObjectsToResolve;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Recursive")]
    protected Primitive<bool> _Recursive;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_SufixIncludeFilter")]
    protected Primitive<string> _SufixIncludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_SufixExcludeFilter")]
    protected Primitive<string> _SufixExcludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_IsRDO")]
    protected Primitive<bool> _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_PrefixIncludeFilter")]
    protected Primitive<string> _PrefixIncludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_PrefixExcludeFilter")]
    protected Primitive<string> _PrefixExcludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_BeginDateFilter")]
    protected Primitive<DateTime> _BeginDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_IncludeData")]
    protected Primitive<bool> _IncludeData;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_CDOFilteredInstances")]
    protected BaseObjectRef _CDOFilteredInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_RORFilter")]
    protected Primitive<bool> _RORFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_FilterReferences")]
    protected Primitive<bool> _FilterReferences;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_EndDateFilter")]
    protected Primitive<DateTime> _EndDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_SelectedInstance")]
    protected BaseObjectRef _SelectedInstance;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_SelectedInstances")]
    protected BaseObjectRef[] _SelectedInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_CDOInstances")]
    protected BaseObjectRef[] _CDOInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_StatusFilter")]
    protected Enumeration<StatusEnum, int> _StatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_EmployeeFilter")]
    protected NamedObjectRef _EmployeeFilter;

    public override bool Equals(object obj)
    {
      return obj is CDOInquiry && object.Equals((object) this._ObjectReferences, (object) ((CDOInquiry) obj)._ObjectReferences) && (object.Equals((object) this._CDODefId, (object) ((CDOInquiry) obj)._CDODefId) && this.CompareArrays((Array) this._ObjectReferencesList, (Array) ((CDOInquiry) obj)._ObjectReferencesList)) && (object.Equals((object) this._CDODefName, (object) ((CDOInquiry) obj)._CDODefName) && this.CompareArrays((Array) this._ObjectsToResolve, (Array) ((CDOInquiry) obj)._ObjectsToResolve) && (object.Equals((object) this._Recursive, (object) ((CDOInquiry) obj)._Recursive) && object.Equals((object) this._SufixIncludeFilter, (object) ((CDOInquiry) obj)._SufixIncludeFilter))) && (object.Equals((object) this._SufixExcludeFilter, (object) ((CDOInquiry) obj)._SufixExcludeFilter) && object.Equals((object) this._IsRDO, (object) ((CDOInquiry) obj)._IsRDO) && (object.Equals((object) this._PrefixIncludeFilter, (object) ((CDOInquiry) obj)._PrefixIncludeFilter) && object.Equals((object) this._PrefixExcludeFilter, (object) ((CDOInquiry) obj)._PrefixExcludeFilter)) && (object.Equals((object) this._BeginDateFilter, (object) ((CDOInquiry) obj)._BeginDateFilter) && object.Equals((object) this._IncludeData, (object) ((CDOInquiry) obj)._IncludeData) && (object.Equals((object) this._CDOFilteredInstances, (object) ((CDOInquiry) obj)._CDOFilteredInstances) && object.Equals((object) this._RORFilter, (object) ((CDOInquiry) obj)._RORFilter)))) && (object.Equals((object) this._FilterReferences, (object) ((CDOInquiry) obj)._FilterReferences) && object.Equals((object) this._EndDateFilter, (object) ((CDOInquiry) obj)._EndDateFilter) && (object.Equals((object) this._SelectedInstance, (object) ((CDOInquiry) obj)._SelectedInstance) && this.CompareArrays((Array) this._SelectedInstances, (Array) ((CDOInquiry) obj)._SelectedInstances)) && (this.CompareArrays((Array) this._CDOInstances, (Array) ((CDOInquiry) obj)._CDOInstances) && object.Equals((object) this._StatusFilter, (object) ((CDOInquiry) obj)._StatusFilter) && object.Equals((object) this._EmployeeFilter, (object) ((CDOInquiry) obj)._EmployeeFilter))) && base.Equals(obj);
    }

    public ObjectReferencesInfo ObjectReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReferences), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo) this.PropertyGet(nameof (ObjectReferences));
      }
    }

    public Enumeration<MaintainableObjectEnum, string> CDODefId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefId), (object) value);
      }
      get
      {
        return (Enumeration<MaintainableObjectEnum, string>) this.PropertyGet(nameof (CDODefId));
      }
    }

    public ObjectReferencesInfo[] ObjectReferencesList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReferencesList), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo[]) this.PropertyGet(nameof (ObjectReferencesList));
      }
    }

    public Enumeration<MaintainableObjectEnum, string> CDODefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefName), (object) value);
      }
      get
      {
        return (Enumeration<MaintainableObjectEnum, string>) this.PropertyGet(nameof (CDODefName));
      }
    }

    public ObjectToResolve[] ObjectsToResolve
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectsToResolve), (object) value);
      }
      get
      {
        return (ObjectToResolve[]) this.PropertyGet(nameof (ObjectsToResolve));
      }
    }

    public Primitive<bool> Recursive
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recursive), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Recursive));
      }
    }

    public Primitive<string> SufixIncludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SufixIncludeFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SufixIncludeFilter));
      }
    }

    public Primitive<string> SufixExcludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SufixExcludeFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SufixExcludeFilter));
      }
    }

    public Primitive<bool> IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Primitive<string> PrefixIncludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrefixIncludeFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PrefixIncludeFilter));
      }
    }

    public Primitive<string> PrefixExcludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrefixExcludeFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PrefixExcludeFilter));
      }
    }

    public Primitive<DateTime> BeginDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginDateFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (BeginDateFilter));
      }
    }

    public Primitive<bool> IncludeData
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeData), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IncludeData));
      }
    }

    public BaseObjectRef CDOFilteredInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOFilteredInstances), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (CDOFilteredInstances));
      }
    }

    public Primitive<bool> RORFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (RORFilter), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RORFilter));
      }
    }

    public Primitive<bool> FilterReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterReferences), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FilterReferences));
      }
    }

    public Primitive<DateTime> EndDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDateFilter));
      }
    }

    public BaseObjectRef SelectedInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstance), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (SelectedInstance));
      }
    }

    public BaseObjectRef[] SelectedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstances), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (SelectedInstances));
      }
    }

    public BaseObjectRef[] CDOInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstances), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (CDOInstances));
      }
    }

    public Enumeration<StatusEnum, int> StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public NamedObjectRef EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EmployeeFilter));
      }
    }
  }
}
