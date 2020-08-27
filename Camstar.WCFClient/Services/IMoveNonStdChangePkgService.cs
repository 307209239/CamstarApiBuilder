// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveNonStdChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveNonStdChangePkgService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_LoadESigDetails_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Parameters parameters,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveNonStdChangePkgMethod[] methods,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveNonStdChangePkg moveNonStdChangePkg,
      MoveNonStdChangePkg_Request request,
      out MoveNonStdChangePkg_Result result);
  }
}
