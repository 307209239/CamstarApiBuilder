// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnDetails_Info
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
  public class TxnDetails_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Info_ReworkReason")]
    protected Info _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Info_NewOwner")]
    protected Info _NewOwner;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Info_ToContainerOption")]
    protected Info _ToContainerOption;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Info_TxnType")]
    protected Info _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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
