// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingObjsToExcludeChanges
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
  public class ModelingObjsToExcludeChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_ModelingCDOTypeId")]
    protected Primitive<int> _ModelingCDOTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingObjsToExcludeChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ModelingObjsToExcludeChanges && object.Equals((object) this._DisplayName, (object) ((ModelingObjsToExcludeChanges) obj)._DisplayName) && (object.Equals((object) this._ObjectToChange, (object) ((ModelingObjsToExcludeChanges) obj)._ObjectToChange) && object.Equals((object) this._ModelingCDOTypeId, (object) ((ModelingObjsToExcludeChanges) obj)._ModelingCDOTypeId)) && object.Equals((object) this._IsFrozen, (object) ((ModelingObjsToExcludeChanges) obj)._IsFrozen) && base.Equals(obj);
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<int> ModelingCDOTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingCDOTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ModelingCDOTypeId));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
