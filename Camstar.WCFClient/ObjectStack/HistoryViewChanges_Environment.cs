// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryViewChanges_Environment
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
  public class HistoryViewChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Environment_HistViewDtls")]
    [Metadata("Changes CDO for UI Preference Detail ", "HistViewDtlChanges", false, false, false, "HistViewDtlChanges", 1050023, false, true, false, null)]
    protected HistViewDtlChanges_Environment _HistViewDtls;
    [Metadata("Changes CDO for UI Pref His Mainline Dtl", "HistViewHistMainlineDtlChanges", false, true, false, "HistViewHistMainlineDtlChanges", 1050024, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Environment_HistViewHistMainlineDtl")]
    protected HistViewHistMainlineDtlChanges_Environment _HistViewHistMainlineDtl;
    [Metadata("The History View object is used to store a user configured view of the History objects.  This object is used by the Live Manufacturing Audit Trail application.", "HistoryView", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Environment_LookupObject")]
    [Metadata("BaseObject", "BaseObject", true, false, false, "BaseObjectRef", 1050027, false, false, true, null)]
    protected Environment _LookupObject;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Environment_HistoryObjects")]
    [Metadata("Generic String", "", true, false, false, "String", 1050026, false, false, true, null)]
    protected Environment _HistoryObjects;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050065, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Environment_Name")]
    protected new Environment _Name;

    public HistViewDtlChanges_Environment HistViewDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewDtls), (object) value);
      }
      get
      {
        return (HistViewDtlChanges_Environment) this.PropertyGet(nameof (HistViewDtls));
      }
    }

    public HistViewHistMainlineDtlChanges_Environment HistViewHistMainlineDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewHistMainlineDtl), (object) value);
      }
      get
      {
        return (HistViewHistMainlineDtlChanges_Environment) this.PropertyGet(nameof (HistViewHistMainlineDtl));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment LookupObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (LookupObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LookupObject));
      }
    }

    public Environment HistoryObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryObjects));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
