// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionChanges
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
  public class DataPointCollectionChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_Groups")]
    protected DataPointCollectionGroupChgs[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionChanges_Instructions")]
    protected Primitive<string> _Instructions;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollectionChanges && this.CompareArrays((Array) this._Groups, (Array) ((DataPointCollectionChanges) obj)._Groups) && (object.Equals((object) this._ObjectToChange, (object) ((DataPointCollectionChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((DataPointCollectionChanges) obj)._ListItemToChange)) && object.Equals((object) this._Instructions, (object) ((DataPointCollectionChanges) obj)._Instructions) && base.Equals(obj);
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
