// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ButtonLabel
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
  public class ButtonLabel : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabel_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabel_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabel_LabelText")]
    protected Primitive<string> _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "ButtonLabel_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ButtonLabel && object.Equals((object) this._ExportImportKey, (object) ((ButtonLabel) obj)._ExportImportKey) && (object.Equals((object) this._LabelName, (object) ((ButtonLabel) obj)._LabelName) && object.Equals((object) this._LabelText, (object) ((ButtonLabel) obj)._LabelText)) && object.Equals((object) this._IsFrozen, (object) ((ButtonLabel) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<string> LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelName));
      }
    }

    public Primitive<string> LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelText));
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
