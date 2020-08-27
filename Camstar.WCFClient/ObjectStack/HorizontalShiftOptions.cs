// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HorizontalShiftOptions
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
  public class HorizontalShiftOptions : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_HorizontalShiftDirection")]
    protected Enumeration<UIHorizontalShiftTypeEnum, int> _HorizontalShiftDirection;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_HorizontalShiftValue")]
    protected Primitive<int> _HorizontalShiftValue;
    [DataMember(EmitDefaultValue = false, Name = "HorizontalShiftOptions_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is HorizontalShiftOptions && object.Equals((object) this._ExportImportKey, (object) ((HorizontalShiftOptions) obj)._ExportImportKey) && (object.Equals((object) this._HorizontalShiftDirection, (object) ((HorizontalShiftOptions) obj)._HorizontalShiftDirection) && object.Equals((object) this._HorizontalShiftValue, (object) ((HorizontalShiftOptions) obj)._HorizontalShiftValue)) && object.Equals((object) this._IsFrozen, (object) ((HorizontalShiftOptions) obj)._IsFrozen) && base.Equals(obj);
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

    public Enumeration<UIHorizontalShiftTypeEnum, int> HorizontalShiftDirection
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftDirection), (object) value);
      }
      get
      {
        return (Enumeration<UIHorizontalShiftTypeEnum, int>) this.PropertyGet(nameof (HorizontalShiftDirection));
      }
    }

    public Primitive<int> HorizontalShiftValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShiftValue), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (HorizontalShiftValue));
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
