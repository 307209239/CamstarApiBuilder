// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaterialContainerHistoryDetail_Environment
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
  public class MaterialContainerHistoryDetail_Environment : StartHistoryDetail_Environment
  {
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaterialContainerHistoryDetail_Environment_MasterRecipe")]
    protected Environment _MasterRecipe;

    public Environment MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MasterRecipe));
      }
    }
  }
}
