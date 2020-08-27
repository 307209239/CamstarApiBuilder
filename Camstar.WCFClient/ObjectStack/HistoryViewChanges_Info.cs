// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryViewChanges_Info
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
  public class HistoryViewChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Info_HistViewDtls")]
    protected HistViewDtlChanges_Info _HistViewDtls;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Info_HistViewHistMainlineDtl")]
    protected HistViewHistMainlineDtlChanges_Info _HistViewHistMainlineDtl;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Info_LookupObject")]
    protected Info _LookupObject;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Info_HistoryObjects")]
    protected Info _HistoryObjects;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Info_Name")]
    protected new Info _Name;

    public HistViewDtlChanges_Info HistViewDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewDtls), (object) value);
      }
      get
      {
        return (HistViewDtlChanges_Info) this.PropertyGet(nameof (HistViewDtls));
      }
    }

    public HistViewHistMainlineDtlChanges_Info HistViewHistMainlineDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewHistMainlineDtl), (object) value);
      }
      get
      {
        return (HistViewHistMainlineDtlChanges_Info) this.PropertyGet(nameof (HistViewHistMainlineDtl));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info LookupObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (LookupObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LookupObject));
      }
    }

    public Info HistoryObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObjects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryObjects));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
