// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedConfigDetailsChanges_Info
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
  public class WhereUsedConfigDetailsChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_ReferencerId")]
    protected Info _ReferencerId;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_DBTableName")]
    protected Info _DBTableName;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_DBTableID")]
    protected Info _DBTableID;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_ObjectColumn")]
    protected Info _ObjectColumn;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_ObjectBaseColumn")]
    protected Info _ObjectBaseColumn;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info ReferencerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferencerId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReferencerId));
      }
    }

    public Info DBTableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DBTableName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DBTableName));
      }
    }

    public Info DBTableID
    {
      [param: In] set
      {
        this.PropertySet(nameof (DBTableID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DBTableID));
      }
    }

    public Info ObjectColumn
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectColumn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectColumn));
      }
    }

    public Info ObjectBaseColumn
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectBaseColumn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectBaseColumn));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
