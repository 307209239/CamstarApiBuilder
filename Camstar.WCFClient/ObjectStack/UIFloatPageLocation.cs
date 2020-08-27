// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLocation
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
  public class UIFloatPageLocation : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocation_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocation_Width")]
    protected Primitive<int> _Width;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocation_Height")]
    protected Primitive<int> _Height;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLocation_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIFloatPageLocation && object.Equals((object) this._ExportImportKey, (object) ((UIFloatPageLocation) obj)._ExportImportKey) && (object.Equals((object) this._Width, (object) ((UIFloatPageLocation) obj)._Width) && object.Equals((object) this._Height, (object) ((UIFloatPageLocation) obj)._Height)) && object.Equals((object) this._IsFrozen, (object) ((UIFloatPageLocation) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<int> Width
    {
      [param: In] set
      {
        this.PropertySet(nameof (Width), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Width));
      }
    }

    public Primitive<int> Height
    {
      [param: In] set
      {
        this.PropertySet(nameof (Height), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Height));
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
