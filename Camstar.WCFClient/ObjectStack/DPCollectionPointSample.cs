// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionPointSample
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
  public class DPCollectionPointSample : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_DataValue")]
    protected Primitive<string> _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DPCollectionPointSample && object.Equals((object) this._ExportImportKey, (object) ((DPCollectionPointSample) obj)._ExportImportKey) && (object.Equals((object) this._DataValue, (object) ((DPCollectionPointSample) obj)._DataValue) && object.Equals((object) this._Name, (object) ((DPCollectionPointSample) obj)._Name)) && object.Equals((object) this._IsFrozen, (object) ((DPCollectionPointSample) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<string> DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DataValue));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<bool> IsFrozen
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
