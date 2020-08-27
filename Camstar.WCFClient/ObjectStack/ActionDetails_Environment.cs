// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDetails_Environment
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
  public class ActionDetails_Environment : Subentity_Environment
  {
    [Metadata("Determines, based on Status and Effective From and Thru dates whether a CDO should be considered for processing.\r\nIf a field is not found within the CDO, a positive result is assumed.", "", false, false, true, "Boolean", 1049431, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActionDetails_Environment_IsEnabled")]
    protected Environment _IsEnabled;
    [DataMember(EmitDefaultValue = false, Name = "ActionDetails_Environment_Action")]
    [Metadata("The Action CDO is based on an ActionRule and used to identify if this action could be performed against an object.", "ActionDef", false, false, true, "NamedObjectRef", 1048937, false, false, false, null)]
    protected Environment _Action;

    public Environment IsEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsEnabled));
      }
    }

    public Environment Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Action));
      }
    }
  }
}
