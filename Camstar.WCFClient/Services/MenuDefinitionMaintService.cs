// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MenuDefinitionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MenuDefinitionMaintService : NamedDataObjectMaintBase
  {
    public MenuDefinitionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMenuDefinitionMaintService), userProfile);
    }

    public ResultStatus Delete(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).Delete(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus Delete(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.Delete(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus Delete(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.Delete(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).Freeze(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus Freeze(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.Freeze(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus Freeze(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.Freeze(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.GetWIPMsgs(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.GetWIPMsgs(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).Load(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus Load(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.Load(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus Load(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.Load(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_LoadESigDetails_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).LoadESigDetails(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.LoadESigDetails, (MenuDefinitionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MenuDefinitionMaint) null, (MenuDefinitionMaint_LoadESigDetails_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.LoadESigDetails(menuDefinitionMaint, (MenuDefinitionMaint_LoadESigDetails_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.LoadESigDetails(menuDefinitionMaint, (MenuDefinitionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).New(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus New(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.New(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus New(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.New(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).NewCopy(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus NewCopy(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.NewCopy(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus NewCopy(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.NewCopy(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).SaveAs(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus SaveAs(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.SaveAs(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus SaveAs(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.SaveAs(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).UnFreeze(this._UserProfile, menuDefinitionMaint, parameters, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(menuDefinitionMaint, MenuDefinitionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) menuDefinitionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MenuDefinitionMaint) null, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus UnFreeze(MenuDefinitionMaint menuDefinitionMaint)
    {
      return this.UnFreeze(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.UnFreeze(menuDefinitionMaint, (MenuDefinitionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_LoadESigDetails_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.New((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.Load((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject menuDefinitionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MenuDefinitionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MenuDefinitionMaint) menuDefinitionMaint, (MenuDefinitionMaint_Parameters) parameters, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      try
      {
        MenuDefinitionMaintMethod[] methods = new MenuDefinitionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMenuDefinitionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MenuDefinitionMaint cdo,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      try
      {
        return ((IMenuDefinitionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MenuDefinitionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MenuDefinitionMaint) cdo, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.GetEnvironment((MenuDefinitionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MenuDefinitionMaint cdo,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      result = (MenuDefinitionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMenuDefinitionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MenuDefinitionMaintMethod(cdo, MenuDefinitionMaintMethods.ExecuteTransaction, (MenuDefinitionMaint_Parameters) null));
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
        MenuDefinitionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MenuDefinitionMaint) cdo, (MenuDefinitionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MenuDefinitionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MenuDefinitionMaint_Request) null, out MenuDefinitionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result)
    {
      return this.ExecuteTransaction((MenuDefinitionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MenuDefinitionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MenuDefinitionMaintMethod(cdo, MenuDefinitionMaintMethods.AddDataTransaction, (MenuDefinitionMaint_Parameters) null));
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
        return this.AddDataTransaction((MenuDefinitionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
