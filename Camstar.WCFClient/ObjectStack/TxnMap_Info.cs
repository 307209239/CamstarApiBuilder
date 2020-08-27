// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnMap_Info
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
  public class TxnMap_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_TxnType")]
    protected Info _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_Required")]
    protected Info _Required;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_TxnToUse")]
    protected Info _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

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

    public Info Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Required), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Required));
      }
    }

    public Info TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnToUse));
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
