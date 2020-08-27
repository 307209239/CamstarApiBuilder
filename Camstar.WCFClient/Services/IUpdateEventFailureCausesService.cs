// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUpdateEventFailureCausesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUpdateEventFailureCausesService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Parameters parameters,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UpdateEventFailureCausesMethod[] methods,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UpdateEventFailureCauses updateEventFailureCauses,
      UpdateEventFailureCauses_Request request,
      out UpdateEventFailureCauses_Result result);
  }
}
