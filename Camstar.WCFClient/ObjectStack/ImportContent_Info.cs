// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ImportContent_Info
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
  public class ImportContent_Info : ObjectAlternateKey_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_Info_ImportStatus")]
    protected Info _ImportStatus;
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_Info_ObjectIsModified")]
    protected Info _ObjectIsModified;
    [DataMember(EmitDefaultValue = false, Name = "ImportContent_Info_ObjectAlreadyExists")]
    protected Info _ObjectAlreadyExists;

    public Info ImportStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImportStatus));
      }
    }

    public Info ObjectIsModified
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectIsModified), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectIsModified));
      }
    }

    public Info ObjectAlreadyExists
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectAlreadyExists), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectAlreadyExists));
      }
    }
  }
}
