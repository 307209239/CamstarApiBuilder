// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionGroupHistory
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
  public class DPCollectionGroupHistory : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_GroupLayout")]
    protected Enumeration<DPCollectionGroupLayoutEnum, int> _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_HistoryDetails")]
    protected SubentityRef[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Group")]
    protected NamedSubentityRef _Group;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionGroupHistory_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DPCollectionGroupHistory && object.Equals((object) this._ExportImportKey, (object) ((DPCollectionGroupHistory) obj)._ExportImportKey) && (object.Equals((object) this._Sequence, (object) ((DPCollectionGroupHistory) obj)._Sequence) && object.Equals((object) this._GroupLayout, (object) ((DPCollectionGroupHistory) obj)._GroupLayout)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((DPCollectionGroupHistory) obj)._HistoryDetails) && object.Equals((object) this._Group, (object) ((DPCollectionGroupHistory) obj)._Group) && (object.Equals((object) this._HistoryId, (object) ((DPCollectionGroupHistory) obj)._HistoryId) && object.Equals((object) this._MinimumSamples, (object) ((DPCollectionGroupHistory) obj)._MinimumSamples))) && object.Equals((object) this._Name, (object) ((DPCollectionGroupHistory) obj)._Name) && base.Equals(obj);
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

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Enumeration<DPCollectionGroupLayoutEnum, int> GroupLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (GroupLayout), (object) value);
      }
      get
      {
        return (Enumeration<DPCollectionGroupLayoutEnum, int>) this.PropertyGet(nameof (GroupLayout));
      }
    }

    public SubentityRef[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public NamedSubentityRef Group
    {
      [param: In] set
      {
        this.PropertySet(nameof (Group), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Group));
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

    public Primitive<int> MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
