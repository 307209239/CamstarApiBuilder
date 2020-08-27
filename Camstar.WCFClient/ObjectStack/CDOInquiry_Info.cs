// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOInquiry_Info
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
  public class CDOInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_ObjectReferences")]
    protected ObjectReferencesInfo_Info _ObjectReferences;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_CDODefId")]
    protected Info _CDODefId;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_ObjectReferencesList")]
    protected ObjectReferencesInfo_Info _ObjectReferencesList;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_CDODefName")]
    protected Info _CDODefName;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_ObjectsToResolve")]
    protected ObjectToResolve_Info _ObjectsToResolve;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_Recursive")]
    protected Info _Recursive;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_SufixIncludeFilter")]
    protected Info _SufixIncludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_SufixExcludeFilter")]
    protected Info _SufixExcludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_IsRDO")]
    protected Info _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_PrefixIncludeFilter")]
    protected Info _PrefixIncludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_PrefixExcludeFilter")]
    protected Info _PrefixExcludeFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_BeginDateFilter")]
    protected Info _BeginDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_IncludeData")]
    protected Info _IncludeData;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_CDOFilteredInstances")]
    protected Info _CDOFilteredInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_RORFilter")]
    protected Info _RORFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_FilterReferences")]
    protected Info _FilterReferences;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_EndDateFilter")]
    protected Info _EndDateFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_SelectedInstance")]
    protected Info _SelectedInstance;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_SelectedInstances")]
    protected Info _SelectedInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_CDOInstances")]
    protected Info _CDOInstances;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_StatusFilter")]
    protected Info _StatusFilter;
    [DataMember(EmitDefaultValue = false, Name = "CDOInquiry_Info_EmployeeFilter")]
    protected Info _EmployeeFilter;

    public ObjectReferencesInfo_Info ObjectReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReferences), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo_Info) this.PropertyGet(nameof (ObjectReferences));
      }
    }

    public Info CDODefId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDODefId));
      }
    }

    public ObjectReferencesInfo_Info ObjectReferencesList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReferencesList), (object) value);
      }
      get
      {
        return (ObjectReferencesInfo_Info) this.PropertyGet(nameof (ObjectReferencesList));
      }
    }

    public Info CDODefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDODefName));
      }
    }

    public ObjectToResolve_Info ObjectsToResolve
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectsToResolve), (object) value);
      }
      get
      {
        return (ObjectToResolve_Info) this.PropertyGet(nameof (ObjectsToResolve));
      }
    }

    public Info Recursive
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recursive), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Recursive));
      }
    }

    public Info SufixIncludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SufixIncludeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SufixIncludeFilter));
      }
    }

    public Info SufixExcludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SufixExcludeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SufixExcludeFilter));
      }
    }

    public Info IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Info PrefixIncludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrefixIncludeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrefixIncludeFilter));
      }
    }

    public Info PrefixExcludeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrefixExcludeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrefixExcludeFilter));
      }
    }

    public Info BeginDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (BeginDateFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BeginDateFilter));
      }
    }

    public Info IncludeData
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeData));
      }
    }

    public Info CDOFilteredInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOFilteredInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDOFilteredInstances));
      }
    }

    public Info RORFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (RORFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RORFilter));
      }
    }

    public Info FilterReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterReferences), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterReferences));
      }
    }

    public Info EndDateFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDateFilter));
      }
    }

    public Info SelectedInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstance), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedInstance));
      }
    }

    public Info SelectedInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedInstances));
      }
    }

    public Info CDOInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstances), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CDOInstances));
      }
    }

    public Info StatusFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusFilter));
      }
    }

    public Info EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeFilter));
      }
    }
  }
}
