// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DecisionTreeDetail_Environment
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
  public class DecisionTreeDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Comments", "", false, true, false, "String", 1051732, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeDetail_Environment_Response")]
    protected Environment _Response;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeDetail_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, true, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Comments", "", false, true, false, "String", 1051731, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeDetail_Environment_Question")]
    protected Environment _Question;

    public Environment Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Response));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment Question
    {
      [param: In] set
      {
        this.PropertySet(nameof (Question), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Question));
      }
    }
  }
}
