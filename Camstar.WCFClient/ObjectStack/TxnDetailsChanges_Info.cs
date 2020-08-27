// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnDetailsChanges_Info
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
  public class TxnDetailsChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_TxnType")]
    protected Info _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_ToContainerLevel")]
    protected Info _ToContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_ToContainerName")]
    protected Info _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_ToContainerOption")]
    protected Info _ToContainerOption;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_NewOwner")]
    protected Info _NewOwner;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnType));
      }
    }

    public Info ToContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainerLevel));
      }
    }

    public Info ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public Info ToContainerOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToContainerOption));
      }
    }

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

    public Info NewOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewOwner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewOwner));
      }
    }

    public Info ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkReason));
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
