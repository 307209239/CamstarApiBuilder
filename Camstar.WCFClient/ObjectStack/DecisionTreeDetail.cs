// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DecisionTreeDetail
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
  public class DecisionTreeDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeDetail_Response")]
    protected Primitive<string> _Response;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeDetail_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DecisionTreeDetail_Question")]
    protected Primitive<string> _Question;

    public override bool Equals(object obj)
    {
      return obj is DecisionTreeDetail && object.Equals((object) this._Response, (object) ((DecisionTreeDetail) obj)._Response) && (object.Equals((object) this._Sequence, (object) ((DecisionTreeDetail) obj)._Sequence) && object.Equals((object) this._Question, (object) ((DecisionTreeDetail) obj)._Question)) && base.Equals(obj);
    }

    public Primitive<string> Response
    {
      [param: In] set
      {
        this.PropertySet(nameof (Response), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Response));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<string> Question
    {
      [param: In] set
      {
        this.PropertySet(nameof (Question), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Question));
      }
    }
  }
}
