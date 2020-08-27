// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelTxnMap_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerLabelMap_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class LabelTxnMap_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_Info_LabelCount")]
    protected Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_Info_PrinterLabelDefinition")]
    protected Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_Info_TxnType")]
    protected Info _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_Info_IsFrozen")]
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

    public Info LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelCount));
      }
    }

    public Info PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrinterLabelDefinition));
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
