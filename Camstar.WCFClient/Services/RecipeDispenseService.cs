// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RecipeDispenseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RecipeDispenseService : ComponentIssueBase
  {
    public RecipeDispenseService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRecipeDispenseService), userProfile);
    }

    public ResultStatus CreateParametricData(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).CreateParametricData(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus CreateParametricData(RecipeDispense recipeDispense)
    {
      return this.CreateParametricData(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus CreateParametricData(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.CreateParametricData(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).GetActions(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus GetActions(RecipeDispense recipeDispense)
    {
      return this.GetActions(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus GetActions(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.GetActions(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).GetDataPoints(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus GetDataPoints(RecipeDispense recipeDispense)
    {
      return this.GetDataPoints(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus GetDataPoints(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.GetDataPoints(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).GetWIPMsgs(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus GetWIPMsgs(RecipeDispense recipeDispense)
    {
      return this.GetWIPMsgs(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.GetWIPMsgs(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).Load(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus Load(RecipeDispense recipeDispense)
    {
      return this.Load(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus Load(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.Load(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RecipeDispense recipeDispense,
      RecipeDispense_LoadESigDetails_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).LoadESigDetails(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.LoadESigDetails, (RecipeDispense_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RecipeDispense) null, (RecipeDispense_LoadESigDetails_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus LoadESigDetails(RecipeDispense recipeDispense)
    {
      return this.LoadESigDetails(recipeDispense, (RecipeDispense_LoadESigDetails_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus LoadESigDetails(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.LoadESigDetails(recipeDispense, (RecipeDispense_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).ProcessComputation(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ProcessComputation(RecipeDispense recipeDispense)
    {
      return this.ProcessComputation(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ProcessComputation(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.ProcessComputation(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).ResolveParametricData(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ResolveParametricData(RecipeDispense recipeDispense)
    {
      return this.ResolveParametricData(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ResolveParametricData(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.ResolveParametricData(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus ValidateBatchStatus(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (ValidateBatchStatus), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).ValidateBatchStatus(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.ValidateBatchStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateBatchStatus), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateBatchStatus()
    {
      return this.ValidateBatchStatus((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ValidateBatchStatus(RecipeDispense recipeDispense)
    {
      return this.ValidateBatchStatus(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ValidateBatchStatus(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.ValidateBatchStatus(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    public ResultStatus ValidateExpirationDates(
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (ValidateExpirationDates), (DCObject) recipeDispense, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).ValidateExpirationDates(this._UserProfile, recipeDispense, parameters, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(recipeDispense, RecipeDispenseMethods.ValidateExpirationDates, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateExpirationDates), res, (DCObject) recipeDispense, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateExpirationDates()
    {
      return this.ValidateExpirationDates((RecipeDispense) null, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ValidateExpirationDates(RecipeDispense recipeDispense)
    {
      return this.ValidateExpirationDates(recipeDispense, (RecipeDispense_Parameters) null, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ValidateExpirationDates(
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.ValidateExpirationDates(recipeDispense, (RecipeDispense_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus parametricData = this.CreateParametricData((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus actions = this.GetActions((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RecipeDispense) recipeDispense, (RecipeDispense_LoadESigDetails_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus resultStatus = this.Load((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject recipeDispense,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RecipeDispense) recipeDispense, (RecipeDispense_Parameters) parameters, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      try
      {
        RecipeDispenseMethod[] methods = new RecipeDispenseMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRecipeDispenseService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecipeDispense cdo,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      try
      {
        return ((IRecipeDispenseService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus environment = this.GetEnvironment((RecipeDispense) cdo, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.GetEnvironment((RecipeDispense) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RecipeDispense cdo,
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      result = (RecipeDispense_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRecipeDispenseService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RecipeDispenseMethod(cdo, RecipeDispenseMethods.ExecuteTransaction, (RecipeDispense_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RecipeDispense_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RecipeDispense) cdo, (RecipeDispense_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RecipeDispense cdo)
    {
      return this.ExecuteTransaction(cdo, (RecipeDispense_Request) null, out RecipeDispense_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RecipeDispense_Request request,
      out RecipeDispense_Result result)
    {
      return this.ExecuteTransaction((RecipeDispense) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RecipeDispense cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RecipeDispenseMethod(cdo, RecipeDispenseMethods.AddDataTransaction, (RecipeDispense_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((RecipeDispense) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
