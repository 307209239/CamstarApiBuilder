﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBusinessRuleHandlerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBusinessRuleHandlerMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_LoadESigDetails_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BusinessRuleHandlerMaintMethod[] methods,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result);
  }
}
