// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QueryStringParameter
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
  public class QueryStringParameter : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameter_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameter_SourceMember")]
    protected Primitive<string> _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameter_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameter_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is QueryStringParameter && object.Equals((object) this._ExportImportKey, (object) ((QueryStringParameter) obj)._ExportImportKey) && (object.Equals((object) this._SourceMember, (object) ((QueryStringParameter) obj)._SourceMember) && object.Equals((object) this._Name, (object) ((QueryStringParameter) obj)._Name)) && object.Equals((object) this._IsFrozen, (object) ((QueryStringParameter) obj)._IsFrozen) && base.Equals(obj);
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

    public Primitive<string> SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SourceMember));
      }
    }

    public Primitive<string> Name
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
