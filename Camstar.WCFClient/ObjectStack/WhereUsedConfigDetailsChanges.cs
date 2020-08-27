// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedConfigDetailsChanges
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
  public class WhereUsedConfigDetailsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_ReferencerId")]
    protected Primitive<string> _ReferencerId;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_DBTableName")]
    protected Primitive<string> _DBTableName;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_DBTableID")]
    protected Primitive<int> _DBTableID;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_ObjectColumn")]
    protected Primitive<string> _ObjectColumn;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_ObjectBaseColumn")]
    protected Primitive<string> _ObjectBaseColumn;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is WhereUsedConfigDetailsChanges && object.Equals((object) this._ObjectToChange, (object) ((WhereUsedConfigDetailsChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((WhereUsedConfigDetailsChanges) obj)._ListItemToChange) && object.Equals((object) this._ReferencerId, (object) ((WhereUsedConfigDetailsChanges) obj)._ReferencerId)) && (object.Equals((object) this._DBTableName, (object) ((WhereUsedConfigDetailsChanges) obj)._DBTableName) && object.Equals((object) this._DBTableID, (object) ((WhereUsedConfigDetailsChanges) obj)._DBTableID) && (object.Equals((object) this._ObjectColumn, (object) ((WhereUsedConfigDetailsChanges) obj)._ObjectColumn) && object.Equals((object) this._ObjectBaseColumn, (object) ((WhereUsedConfigDetailsChanges) obj)._ObjectBaseColumn))) && object.Equals((object) this._IsFrozen, (object) ((WhereUsedConfigDetailsChanges) obj)._IsFrozen) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<string> ReferencerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferencerId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReferencerId));
      }
    }

    public Primitive<string> DBTableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DBTableName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DBTableName));
      }
    }

    public Primitive<int> DBTableID
    {
      [param: In] set
      {
        this.PropertySet(nameof (DBTableID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DBTableID));
      }
    }

    public Primitive<string> ObjectColumn
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectColumn), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectColumn));
      }
    }

    public Primitive<string> ObjectBaseColumn
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectBaseColumn), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectBaseColumn));
      }
    }

    public Primitive<bool> IsFrozen
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
  }
}
