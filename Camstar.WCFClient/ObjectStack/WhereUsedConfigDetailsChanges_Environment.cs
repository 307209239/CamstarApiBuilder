// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedConfigDetailsChanges_Environment
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
  public class WhereUsedConfigDetailsChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_ObjectToChange")]
    [Metadata("List of configurations used in upward dependency search.", "WhereUsedConfigDetails", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_ListItemToChange")]
    [Metadata("List of configurations used in upward dependency search.", "WhereUsedConfigDetailsChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_ReferencerId")]
    [Metadata("Generic String", "", false, false, false, "String", 16778021, false, false, false, null)]
    protected Environment _ReferencerId;
    [Metadata("Generic String", "", false, false, false, "String", 16778018, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_DBTableName")]
    protected Environment _DBTableName;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_DBTableID")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16778060, false, false, false, null)]
    protected Environment _DBTableID;
    [Metadata("Generic String", "", false, false, false, "String", 16778019, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_ObjectColumn")]
    protected Environment _ObjectColumn;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_ObjectBaseColumn")]
    [Metadata("Generic String", "", false, false, false, "String", 16778020, false, false, false, null)]
    protected Environment _ObjectBaseColumn;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigDetailsChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment ReferencerId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferencerId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReferencerId));
      }
    }

    public Environment DBTableName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DBTableName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DBTableName));
      }
    }

    public Environment DBTableID
    {
      [param: In] set
      {
        this.PropertySet(nameof (DBTableID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DBTableID));
      }
    }

    public Environment ObjectColumn
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectColumn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectColumn));
      }
    }

    public Environment ObjectBaseColumn
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectBaseColumn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectBaseColumn));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
