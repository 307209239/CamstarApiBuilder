// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUnitStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUnitStartService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_LoadESigDetails_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Parameters parameters,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UnitStartMethod[] methods,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UnitStart unitStart,
      UnitStart_Request request,
      out UnitStart_Result result);
  }
}
