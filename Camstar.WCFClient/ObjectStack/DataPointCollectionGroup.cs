// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionGroup
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
  public class DataPointCollectionGroup : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_LastEnteredByRole")]
    protected NamedObjectRef _LastEnteredByRole;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Points")]
    protected DataPointCollectionPoint[] _Points;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_GroupLayout")]
    protected Enumeration<DPCollectionGroupLayoutEnum, int> _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_LastEnteredOn")]
    protected Primitive<DateTime> _LastEnteredOn;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_LastEnteredOnGMT")]
    protected Primitive<DateTime> _LastEnteredOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroup_LastEnteredBy")]
    protected NamedObjectRef _LastEnteredBy;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollectionGroup && object.Equals((object) this._ExportImportKey, (object) ((DataPointCollectionGroup) obj)._ExportImportKey) && (object.Equals((object) this._LastEnteredByRole, (object) ((DataPointCollectionGroup) obj)._LastEnteredByRole) && this.CompareArrays((Array) this._Points, (Array) ((DataPointCollectionGroup) obj)._Points)) && (object.Equals((object) this._GroupLayout, (object) ((DataPointCollectionGroup) obj)._GroupLayout) && object.Equals((object) this._Sequence, (object) ((DataPointCollectionGroup) obj)._Sequence) && (object.Equals((object) this._MinimumSamples, (object) ((DataPointCollectionGroup) obj)._MinimumSamples) && object.Equals((object) this._LastEnteredOn, (object) ((DataPointCollectionGroup) obj)._LastEnteredOn))) && (object.Equals((object) this._LastEnteredOnGMT, (object) ((DataPointCollectionGroup) obj)._LastEnteredOnGMT) && object.Equals((object) this._IsFrozen, (object) ((DataPointCollectionGroup) obj)._IsFrozen) && (object.Equals((object) this._Name, (object) ((DataPointCollectionGroup) obj)._Name) && object.Equals((object) this._LastEnteredBy, (object) ((DataPointCollectionGroup) obj)._LastEnteredBy))) && base.Equals(obj);
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

    public NamedObjectRef LastEnteredByRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredByRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastEnteredByRole));
      }
    }

    public DataPointCollectionPoint[] Points
    {
      [param: In] set
      {
        this.PropertySet(nameof (Points), (object) value);
      }
      get
      {
        return (DataPointCollectionPoint[]) this.PropertyGet(nameof (Points));
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

    public Primitive<DateTime> LastEnteredOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastEnteredOn));
      }
    }

    public Primitive<DateTime> LastEnteredOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastEnteredOnGMT));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<string> Name
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

    public NamedObjectRef LastEnteredBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEnteredBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastEnteredBy));
      }
    }
  }
}
