﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ILabelService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ILabelService
  {
    [OperationContract]
    ResultStatus GetLabels(
      UserProfile userProfile,
      LabelRequest request,
      out LabelResult result);
  }
}
