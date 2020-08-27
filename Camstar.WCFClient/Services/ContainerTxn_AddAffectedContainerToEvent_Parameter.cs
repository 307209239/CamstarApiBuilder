// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxn_AddAffectedContainerToEvent_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerTxn_AddAffectedContainerToEvent_Parameters : ContainerTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Event")]
    protected string _Event;
    [DataMember(EmitDefaultValue = false, Name = "CDOTypeId")]
    protected string _CDOTypeId;
    [DataMember(EmitDefaultValue = false, Name = "Container")]
    protected string _Container;

    public string Event
    {
      [param: In] set
      {
        this.PropertySet(nameof (Event), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Event));
      }
    }

    public string CDOTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypeId), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (CDOTypeId));
      }
    }

    public string Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Container));
      }
    }
  }
}
