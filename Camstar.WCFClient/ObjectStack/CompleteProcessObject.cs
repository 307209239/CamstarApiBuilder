// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteProcessObject
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
  public class CompleteProcessObject : ProcessObjectTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObject_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObject_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObject_CompletionComments")]
    protected Primitive<string> _CompletionComments;

    public override bool Equals(object obj)
    {
      return obj is CompleteProcessObject && object.Equals((object) this._Comments, (object) ((CompleteProcessObject) obj)._Comments) && (object.Equals((object) this._DueDate, (object) ((CompleteProcessObject) obj)._DueDate) && object.Equals((object) this._CompletionComments, (object) ((CompleteProcessObject) obj)._CompletionComments)) && base.Equals(obj);
    }

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public Primitive<string> CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionComments));
      }
    }
  }
}
