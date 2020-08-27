// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionDefChanges
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
  public class DataPointCollectionDefChanges : DataCollectionDefChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Groups")]
    protected DataPointCollectionGroupChgs[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_ParametricDataDefType")]
    protected new Primitive<int> _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionDefChanges_Instructions")]
    protected Primitive<string> _Instructions;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollectionDefChanges && this.CompareArrays((Array) this._Groups, (Array) ((DataPointCollectionDefChanges) obj)._Groups) && (object.Equals((object) this._Base, (object) ((DataPointCollectionDefChanges) obj)._Base) && object.Equals((object) this._ObjectToChange, (object) ((DataPointCollectionDefChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ParametricDataDefType, (object) ((DataPointCollectionDefChanges) obj)._ParametricDataDefType) && object.Equals((object) this._Name, (object) ((DataPointCollectionDefChanges) obj)._Name) && object.Equals((object) this._Instructions, (object) ((DataPointCollectionDefChanges) obj)._Instructions)) && base.Equals(obj);
    }

    public DataPointCollectionGroupChgs[] Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (DataPointCollectionGroupChgs[]) this.PropertyGet(nameof (Groups));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<int> ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ParametricDataDefType));
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

    public Primitive<string> Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instructions));
      }
    }
  }
}
