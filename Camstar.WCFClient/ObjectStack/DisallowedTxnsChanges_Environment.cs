// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DisallowedTxnsChanges_Environment
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
  public class DisallowedTxnsChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_ListItemToChange")]
    [Metadata("Changes CDO for DisallowedTxns.", "DisallowedTxnsChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1048909, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_TxnType")]
    protected Environment _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_DisallowAll")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048974, false, false, false, "0")]
    protected Environment _DisallowAll;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1048975, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_TxnName")]
    protected Environment _TxnName;
    [Metadata("Each Operation Definition includes a list of Transactions that are not allowed at that Operation. An instance of this CDO defines an entry in that list.\r\n", "DisallowedTxns", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
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

    public Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
      }
    }

    public Environment DisallowAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowAll), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisallowAll));
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

    public Environment TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnName));
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
  }
}
