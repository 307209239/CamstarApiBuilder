// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDetails_Info
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
  public class ActionDetails_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDetails_Info_IsEnabled")]
    protected Info _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ActionDetails_Info_Action")]
    protected Info _Action;

    public Info IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Info Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Action));
      }
    }
  }
}
