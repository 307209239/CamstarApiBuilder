// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceLogChanges_Environment
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
  public class ResourceLogChanges_Environment : CurrentResourceStatusChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceLogChanges_Environment_ListItemToChange")]
    [Metadata("ResourceLogChanges\r\nNOTE: This is NOT Impletemented in the current version", "ResourceLogChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("ResourceLog\r\nNOTE: This is NOT Impletemented in the current version", "ResourceLog", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceLogChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
