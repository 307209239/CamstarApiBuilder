// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataTransportChanges_Info
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
  public class DataTransportChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_Password")]
    protected Info _Password;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_URL")]
    protected Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_UserName")]
    protected Info _UserName;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_TransportAssembly")]
    protected Info _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_IsSynchronous")]
    protected Info _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_OkToTerminateIfFails")]
    protected Info _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Info_TransportType")]
    protected Info _TransportType;

    public Info Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Password));
      }
    }

    public Info URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (URL));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserName));
      }
    }

    public Info TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public Info IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public Info OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OkToTerminateIfFails));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransportType));
      }
    }
  }
}
