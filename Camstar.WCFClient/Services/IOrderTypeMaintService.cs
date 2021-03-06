﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IOrderTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IOrderTypeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_LoadESigDetails_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Parameters parameters,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      OrderTypeMaintMethod[] methods,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      OrderTypeMaint orderTypeMaint,
      OrderTypeMaint_Request request,
      out OrderTypeMaint_Result result);
  }
}
