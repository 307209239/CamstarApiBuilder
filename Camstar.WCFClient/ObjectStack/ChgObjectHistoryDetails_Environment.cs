// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgObjectHistoryDetails_Environment
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
  public class ChgObjectHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectHistoryDetails_Environment_OldObject")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049753, false, false, false, null)]
    protected Environment _OldObject;
    [DataMember(EmitDefaultValue = false, Name = "ChgObjectHistoryDetails_Environment_NewObject")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049752, false, false, false, null)]
    protected Environment _NewObject;

    public Environment OldObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldObject));
      }
    }

    public Environment NewObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewObject));
      }
    }
  }
}
