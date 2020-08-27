// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkPath
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
  public class ReworkPath : Path
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkPath_ReEntryStep")]
    protected NamedSubentityRef _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPath_EndReworkStep")]
    protected NamedSubentityRef _EndReworkStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkPath_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ReworkPath && object.Equals((object) this._ReEntryStep, (object) ((ReworkPath) obj)._ReEntryStep) && (object.Equals((object) this._EndReworkStep, (object) ((ReworkPath) obj)._EndReworkStep) && object.Equals((object) this._Name, (object) ((ReworkPath) obj)._Name)) && base.Equals(obj);
    }

    public NamedSubentityRef ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public NamedSubentityRef EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (EndReworkStep));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
