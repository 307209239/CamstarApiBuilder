// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportContent
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
  public class ImportContent : ObjectAlternateKey
  {
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_ImportStatus")]
    protected Enumeration<ExportImportDetailStatusEnum, int> _ImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_ObjectIsModified")]
    protected Primitive<bool> _ObjectIsModified;
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_ObjectAlreadyExists")]
    protected Primitive<bool> _ObjectAlreadyExists;

    public override bool Equals(object obj)
    {
      return obj is ImportContent && object.Equals((object) this._ImportStatus, (object) ((ImportContent) obj)._ImportStatus) && (object.Equals((object) this._ObjectIsModified, (object) ((ImportContent) obj)._ObjectIsModified) && object.Equals((object) this._ObjectAlreadyExists, (object) ((ImportContent) obj)._ObjectAlreadyExists)) && base.Equals(obj);
    }

    public Enumeration<ExportImportDetailStatusEnum, int> ImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportStatus), (object) value);
      }
      get
      {
        return (Enumeration<ExportImportDetailStatusEnum, int>) this.PropertyGet(nameof (ImportStatus));
      }
    }

    public Primitive<bool> ObjectIsModified
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectIsModified), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ObjectIsModified));
      }
    }

    public Primitive<bool> ObjectAlreadyExists
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectAlreadyExists), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ObjectAlreadyExists));
      }
    }
  }
}
