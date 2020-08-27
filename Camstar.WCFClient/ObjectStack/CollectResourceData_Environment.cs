// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectResourceData_Environment
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
  public class CollectResourceData_Environment : ResourceTxn_Environment
  {
    [Metadata("Parametric data", "ParametricData", false, false, false, "ParametricData", 1048871, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectResourceData_Environment_ParametricData")]
    protected new ParametricData_Environment _ParametricData;
    [DataMember(EmitDefaultValue = false, Name = "CollectResourceData_Environment_DataCollectionDef")]
    [Metadata("A Data Collection Definition is used to provide revision control for referencing a parametircdata CDO.", "DataCollectionDef", false, true, false, "RevisionedObjectRef", 1048868, false, false, true, null)]
    protected new Environment _DataCollectionDef;

    public new ParametricData_Environment ParametricData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricData), (object) value);
      }
      get
      {
        return (ParametricData_Environment) this.PropertyGet(nameof (ParametricData));
      }
    }

    public new Environment DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataCollectionDef));
      }
    }
  }
}
