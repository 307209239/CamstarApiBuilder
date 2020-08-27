// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollection
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
  public class DataPointCollection : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Groups")]
    protected DataPointCollectionGroup[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Instructions")]
    protected Primitive<string> _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollection && object.Equals((object) this._ExportImportKey, (object) ((DataPointCollection) obj)._ExportImportKey) && (this.CompareArrays((Array) this._Groups, (Array) ((DataPointCollection) obj)._Groups) && object.Equals((object) this._Name, (object) ((DataPointCollection) obj)._Name)) && (object.Equals((object) this._Instructions, (object) ((DataPointCollection) obj)._Instructions) && object.Equals((object) this._IsFrozen, (object) ((DataPointCollection) obj)._IsFrozen)) && base.Equals(obj);
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

    public DataPointCollectionGroup[] Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (DataPointCollectionGroup[]) this.PropertyGet(nameof (Groups));
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

    public Primitive<string> Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instructions));
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
