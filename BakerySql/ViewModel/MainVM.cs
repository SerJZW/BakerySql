using BakerySql.DataContext;
using BakerySql.Models;
using BakerySql.Models.Event;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace BakerySql.ViewModel
{
    public class MainVM : Notify
    {
        BakeryDbContext db = new BakeryDbContext();

        public ObservableCollection<Employee> EMPLOYEE { get; set; }
        public ObservableCollection<Post> POST { get; set; }
        public ObservableCollection<WORKING_SHIFT> WORKING_SHIFT { get; set; }
        public ObservableCollection<STORE> STORE { get; set; }
        public ObservableCollection<UNITS> UNITS { get; set; }
        public ObservableCollection<EQUIPMENT> EQUIPMENT { get; set; }
        public ObservableCollection<RECIPE> RECIPE { get; set; }
        public ObservableCollection<SHELF> SHELF { get; set; }
        public ObservableCollection<COOKING_PRODUCT> COOKING_PRODUCT { get; set; }
        public ObservableCollection<INGRIDIENTSINRESIPE> INGRIDIENTSINRESIPE { get; set; }
        public MainVM()
        {
            db.Database.EnsureCreated();
            db.EMPLOYEE.Load(); EMPLOYEE = db.EMPLOYEE.Local.ToObservableCollection();
            db.POST.Load(); POST = db.POST.Local.ToObservableCollection();
            db.WORKING_SHIFT.Load(); WORKING_SHIFT = db.WORKING_SHIFT.Local.ToObservableCollection();
            db.STORE.Load(); STORE = db.STORE.Local.ToObservableCollection();
            db.UNITS.Load(); UNITS = db.UNITS.Local.ToObservableCollection();
            db.EQUIPMENT.Load(); EQUIPMENT = db.EQUIPMENT.Local.ToObservableCollection();
            db.RECIPE.Load(); RECIPE = db.RECIPE.Local.ToObservableCollection();
            db.SHELF.Load(); SHELF = db.SHELF.Local.ToObservableCollection();
            db.COOKING_PRODUCT.Load(); COOKING_PRODUCT = db.COOKING_PRODUCT.Local.ToObservableCollection();
            db.INGRIDIENTSINRESIPE.Load(); INGRIDIENTSINRESIPE = db.INGRIDIENTSINRESIPE.Local.ToObservableCollection();
        }
        #region Employee
        public RelayCommand AddEmployeeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Employee newEmployee = new Employee
                    {
                        Post_ID = 1,
                        Working_shift_ID = 1,
                        Name_Employee = "Новый сотрудник",
                        Date_Of_Birth = DateTime.Now,
                        Passport = 000000,
                        SNILS = 0000000000,
                    };

                    EMPLOYEE.Add(newEmployee);

                    db.EMPLOYEE.Add(newEmployee);

                    db.SaveChanges();
                });
            }
        }
        public RelayCommand DeleteEmployeeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is Employee employeeToDelete)
                    {
                        EMPLOYEE.Remove(employeeToDelete);
                        db.EMPLOYEE.Remove(employeeToDelete);

                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Post
        public RelayCommand AddPostCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Post newPost = new Post
                    {
                        Post_Name = "Новая Должность",
                        Salary = 0.00M
                    };
                    POST.Add(newPost);
                    db.POST.Add(newPost);
                    db.SaveChanges();
                });
            }
        }
        public RelayCommand DeletePostCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is Post PostToDelete)
                    {
                        POST.Remove(PostToDelete);
                        db.POST.Remove(PostToDelete);

                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Work
        public RelayCommand AddWorkCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    WORKING_SHIFT newWork = new WORKING_SHIFT
                    {
                        Work_shedule = "Новый",
                        Work_time = 0
                    };
                    WORKING_SHIFT.Add(newWork);
                    db.WORKING_SHIFT.Add(newWork);
                    db.SaveChanges();
                });
            }
        }

        public RelayCommand DeleteWorkCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is WORKING_SHIFT WorkToDelete)
                    {
                        WORKING_SHIFT.Remove(WorkToDelete);
                        db.WORKING_SHIFT.Remove(WorkToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Recipe
        public RelayCommand AddRecipeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    RECIPE newResipe = new RECIPE
                    {
                        Equipment_ID = 1,
                        Recipe_Name = "Новый Рецепт",
                        CookingTime = new TimeSpan(),
                        Calories = 0,
                    };
                    RECIPE.Add(newResipe);

                    db.RECIPE.Add(newResipe);

                    db.SaveChanges();
                });
            }
        }

        public RelayCommand DeleteRecipeCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is RECIPE RecipeToDelete)
                    {
                        RECIPE.Remove(RecipeToDelete);
                        db.RECIPE.Remove(RecipeToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Equipment
        public RelayCommand AddEquipmentCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    EQUIPMENT newEquip = new EQUIPMENT
                    {
                        Equipment_Name = "Новый Прибор"
                    };
                    EQUIPMENT.Add(newEquip);

                    db.EQUIPMENT.Add(newEquip);

                    db.SaveChanges();
                });
            }
        }

        public RelayCommand DeleteEquipmentCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is EQUIPMENT EquipToDelete)
                    {
                        EQUIPMENT.Remove(EquipToDelete);
                        db.EQUIPMENT.Remove(EquipToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Units
        public RelayCommand AddUnitsCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    UNITS newUnit = new UNITS
                    {
                        Unit_Name = "Новая ЕИ"
                    };
                    UNITS.Add(newUnit);

                    db.UNITS.Add(newUnit);

                    db.SaveChanges();
                });              
            }
        }

        public RelayCommand DeleteUnitsCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is UNITS UnitToDelete)
                    {
                        UNITS.Remove(UnitToDelete);
                        db.UNITS.Remove(UnitToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Store
        public RelayCommand AddStoreCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    STORE newStore = new STORE
                    {
                        ID_Unit = 1,                       
                        Ingridient_Name = "Новый Ингридиент",
                        Ingridient_Count = 0,
                        Cost_per_one = 0,
                    };
                    STORE.Add(newStore);

                    db.STORE.Add(newStore);

                    db.SaveChanges();
                });
            }
        }

        public RelayCommand DeleteStoreCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is STORE StoreToDelete)
                    {
                        STORE.Remove(StoreToDelete);
                        db.STORE.Remove(StoreToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Shelf
        public RelayCommand AddShelfCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    SHELF newShelf = new SHELF
                    {
                        Cooking_ID = 1,
                        Sells = 0
                    };
                    SHELF.Add(newShelf);

                    db.SHELF.Add(newShelf);
                });
            }
        }

        public RelayCommand DeleteShelfCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is SHELF ShelfToDelete)
                    {
                        SHELF.Remove(ShelfToDelete);
                        db.SHELF.Remove(ShelfToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        #region Cooking
        public RelayCommand AddCookingCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    COOKING_PRODUCT newCook = new COOKING_PRODUCT
                    {
                        Recipe_ID = 1,
                        Employee_ID = 1,
                        DateCooking = DateTime.Now,
                        CountProduct = 0,
                        Price = 0.00M,
                    };
                    COOKING_PRODUCT.Add(newCook);

                    db.COOKING_PRODUCT.Add(newCook);

               
                });
            }
        }

        public RelayCommand DeleteCookingCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (obj is COOKING_PRODUCT CookToDelete)
                    {
                        COOKING_PRODUCT.Remove(CookToDelete);
                        db.COOKING_PRODUCT.Remove(CookToDelete);
                        db.SaveChanges();
                    }
                });
            }
        }
        #endregion
        public RelayCommand SaveChangesCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Сохранение Выполнено");
                    }
                    catch (DbUpdateException ex)
                    {
                        Console.WriteLine($"Ошибка сохранения изменений: {ex.Message}");
                    }
                });
            }
        }
        #region smthCommand
        public RelayCommand ExitCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    System.Windows.Application.Current.Shutdown();
              
                });
            }
        }
        #endregion
    }
}

