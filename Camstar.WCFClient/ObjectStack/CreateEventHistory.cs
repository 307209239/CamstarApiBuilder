// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateEventHistory
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
  public class CreateEventHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_HistoryDetails")]
    protected EventHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CreateEventHistory_Submit")]
    protected Primitive<bool> _Submit;

    public override bool Equals(object obj)
    {
      return obj is CreateEventHistory && object.Equals((object) this._ExportImportKey, (object) ((CreateEventHistory) obj)._ExportImportKey) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((CreateEventHistory) obj)._HistoryDetails) && object.Equals((object) this._SubClassification, (object) ((CreateEventHistory) obj)._SubClassification)) && (object.Equals((object) this._Organization, (object) ((CreateEventHistory) obj)._Organization) && object.Equals((object) this._Classification, (object) ((CreateEventHistory) obj)._Classification) && (object.Equals((object) this._HistoryId, (object) ((CreateEventHistory) obj)._HistoryId) && object.Equals((object) this._Submit, (object) ((CreateEventHistory) obj)._Submit))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public EventHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (EventHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<bool> Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Submit));
      }
    }
  }
}
