// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MenuDefinitionMaint_LoadESigDetails_Parameters
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
  public class MenuDefinitionMaint_LoadESigDetails_Parameters : MenuDefinitionMaint_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigMaintAction")]
    protected string _ESigMaintAction;

    public string ESigMaintAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigMaintAction), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ESigMaintAction));
      }
    }
  }
}
