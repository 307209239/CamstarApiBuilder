// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionGroupChgs
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
  public class DataPointCollectionGroupChgs : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_GroupLayout")]
    protected Enumeration<DPCollectionGroupLayoutEnum, int> _GroupLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Points")]
    protected DataPointCollectionPointChgs[] _Points;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionGroupChgs_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollectionGroupChgs && object.Equals((object) this._GroupLayout, (object) ((DataPointCollectionGroupChgs) obj)._GroupLayout) && (this.CompareArrays((Array) this._Points, (Array) ((DataPointCollectionGroupChgs) obj)._Points) && object.Equals((object) this._ListItemToChange, (object) ((DataPointCollectionGroupChgs) obj)._ListItemToChange)) && (object.Equals((object) this._ObjectToChange, (object) ((DataPointCollectionGroupChgs) obj)._ObjectToChange) && object.Equals((object) this._Sequence, (object) ((DataPointCollectionGroupChgs) obj)._Sequence) && (object.Equals((object) this._MinimumSamples, (object) ((DataPointCollectionGroupChgs) obj)._MinimumSamples) && object.Equals((object) this._Name, (object) ((DataPointCollectionGroupChgs) obj)._Name))) && base.Equals(obj);
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

    public DataPointCollectionPointChgs[] Points
    {
      [param: In] set
      {
        this.PropertySet(nameof (Points), (object) value);
      }
      get
      {
        return (DataPointCollectionPointChgs[]) this.PropertyGet(nameof (Points));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
