// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserConstantMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserConstantMaintService : TextVariableMaintBase
  {
    public UserConstantMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserConstantMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).Delete(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus Delete(UserConstantMaint userConstantMaint)
    {
      return this.Delete(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus Delete(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.Delete(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).Freeze(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus Freeze(UserConstantMaint userConstantMaint)
    {
      return this.Freeze(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus Freeze(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.Freeze(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserConstantMaint userConstantMaint)
    {
      return this.GetWIPMsgs(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.GetWIPMsgs(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).Load(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus Load(UserConstantMaint userConstantMaint)
    {
      return this.Load(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus Load(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.Load(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_LoadESigDetails_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).LoadESigDetails(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.LoadESigDetails, (UserConstantMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserConstantMaint) null, (UserConstantMaint_LoadESigDetails_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserConstantMaint userConstantMaint)
    {
      return this.LoadESigDetails(userConstantMaint, (UserConstantMaint_LoadESigDetails_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.LoadESigDetails(userConstantMaint, (UserConstantMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).New(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus New(UserConstantMaint userConstantMaint)
    {
      return this.New(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus New(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.New(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).NewCopy(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus NewCopy(UserConstantMaint userConstantMaint)
    {
      return this.NewCopy(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.NewCopy(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).SaveAs(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus SaveAs(UserConstantMaint userConstantMaint)
    {
      return this.SaveAs(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.SaveAs(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Parameters parameters,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userConstantMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).UnFreeze(this._UserProfile, userConstantMaint, parameters, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(userConstantMaint, UserConstantMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userConstantMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserConstantMaint) null, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus UnFreeze(UserConstantMaint userConstantMaint)
    {
      return this.UnFreeze(userConstantMaint, (UserConstantMaint_Parameters) null, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserConstantMaint userConstantMaint,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.UnFreeze(userConstantMaint, (UserConstantMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserConstantMaint) userConstantMaint, (UserConstantMaint_LoadESigDetails_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.New((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userConstantMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserConstantMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserConstantMaint) userConstantMaint, (UserConstantMaint_Parameters) parameters, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      try
      {
        UserConstantMaintMethod[] methods = new UserConstantMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserConstantMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserConstantMaint cdo,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      try
      {
        return ((IUserConstantMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserConstantMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserConstantMaint) cdo, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.GetEnvironment((UserConstantMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserConstantMaint cdo,
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      result = (UserConstantMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserConstantMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserConstantMaintMethod(cdo, UserConstantMaintMethods.ExecuteTransaction, (UserConstantMaint_Parameters) null));
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
        UserConstantMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserConstantMaint) cdo, (UserConstantMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserConstantMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserConstantMaint_Request) null, out UserConstantMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserConstantMaint_Request request,
      out UserConstantMaint_Result result)
    {
      return this.ExecuteTransaction((UserConstantMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserConstantMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserConstantMaintMethod(cdo, UserConstantMaintMethods.AddDataTransaction, (UserConstantMaint_Parameters) null));
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
        return this.AddDataTransaction((UserConstantMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
