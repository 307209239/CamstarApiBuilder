// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelTxnMap
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerLabelMap))]
  [Serializable]
  public class LabelTxnMap : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_LabelCount")]
    protected Primitive<string> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "LabelTxnMap_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is LabelTxnMap && object.Equals((object) this._ExportImportKey, (object) ((LabelTxnMap) obj)._ExportImportKey) && (object.Equals((object) this._LabelCount, (object) ((LabelTxnMap) obj)._LabelCount) && object.Equals((object) this._PrinterLabelDefinition, (object) ((LabelTxnMap) obj)._PrinterLabelDefinition)) && (object.Equals((object) this._TxnType, (object) ((LabelTxnMap) obj)._TxnType) && object.Equals((object) this._IsFrozen, (object) ((LabelTxnMap) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<string> LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelCount));
      }
    }

    public RevisionedObjectRef PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public Primitive<int> TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnType));
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
