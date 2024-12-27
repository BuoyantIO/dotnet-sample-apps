using Microsoft.AspNetCore.Mvc;

namespace Net8PacketTest.Api.Controllers
{
    [Route("test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var results = await Task.FromResult(Enumerable.Range(1, 100).Select(x => new Data
            {
                Id = Guid.NewGuid(),
                SortOrder = x,
                PropOne = "PropOne",
                PropTwo = "PropTwo",
                PropThree = "PropThree",
                PropFour = "PropFour",
                PropFive = "PropFive",
                PropSix = "PropSix",
                PropSeven = "PropSeven",
                PropEight = "PropEight",
                PropNine = "PropNine",
                PropTen = "PropTen",
                CurrentTime = DateTime.Now,
                State = State.Yes,
                ChildData = new[]
                {
                    new Data
                    {
                        Id = Guid.NewGuid(),
                        SortOrder = x,
                        PropOne = "PropOne",
                        PropTwo = "PropTwo",
                        PropThree = "PropThree",
                        PropFour = "PropFour",
                        PropFive = "PropFive",
                        PropSix = "PropSix",
                        PropSeven = "PropSeven",
                        PropEight = "PropEight",
                        PropNine = "PropNine",
                        PropTen = "PropTen",
                        CurrentTime = DateTime.Now,
                        State = State.Yes,
                        ChildData = new[]
                        {
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            }
                        }
                    },
                    new Data
                    {
                        Id = Guid.NewGuid(),
                        SortOrder = x,
                        PropOne = "PropOne",
                        PropTwo = "PropTwo",
                        PropThree = "PropThree",
                        PropFour = "PropFour",
                        PropFive = "PropFive",
                        PropSix = "PropSix",
                        PropSeven = "PropSeven",
                        PropEight = "PropEight",
                        PropNine = "PropNine",
                        PropTen = "PropTen",
                        CurrentTime = DateTime.Now,
                        State = State.Yes,
                        ChildData = new[]
                        {
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            }
                        }
                    },
                    new Data
                    {
                        Id = Guid.NewGuid(),
                        SortOrder = x,
                        PropOne = "PropOne",
                        PropTwo = "PropTwo",
                        PropThree = "PropThree",
                        PropFour = "PropFour",
                        PropFive = "PropFive",
                        PropSix = "PropSix",
                        PropSeven = "PropSeven",
                        PropEight = "PropEight",
                        PropNine = "PropNine",
                        PropTen = "PropTen",
                        CurrentTime = DateTime.Now,
                        State = State.Yes,
                        ChildData = new[]
                        {
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            }
                        }
                    },
                    new Data
                    {
                        Id = Guid.NewGuid(),
                        SortOrder = x,
                        PropOne = "PropOne",
                        PropTwo = "PropTwo",
                        PropThree = "PropThree",
                        PropFour = "PropFour",
                        PropFive = "PropFive",
                        PropSix = "PropSix",
                        PropSeven = "PropSeven",
                        PropEight = "PropEight",
                        PropNine = "PropNine",
                        PropTen = "PropTen",
                        CurrentTime = DateTime.Now,
                        State = State.Yes,
                        ChildData = new[]
                        {
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            },
                            new Data
                            {
                                Id = Guid.NewGuid(),
                                SortOrder = x,
                                PropOne = "PropOne",
                                PropTwo = "PropTwo",
                                PropThree = "PropThree",
                                PropFour = "PropFour",
                                PropFive = "PropFive",
                                PropSix = "PropSix",
                                PropSeven = "PropSeven",
                                PropEight = "PropEight",
                                PropNine = "PropNine",
                                PropTen = "PropTen",
                                CurrentTime = DateTime.Now,
                                State = State.Yes,
                            }
                        }
                    }
                }
            }));

            return Ok(results);
        }
    }

    public class Data
    {
        public Guid Id { get; set; }
        public int SortOrder { get; set; }
        public string PropOne { get; set; }
        public string PropTwo { get; set; }
        public string PropThree { get; set; }
        public string PropFour { get; set; }
        public string PropFive { get; set; }
        public string PropSix { get; set; }
        public string PropSeven { get; set; }
        public string PropEight { get; set; }
        public string PropNine { get; set; }
        public string PropTen { get; set; }
        public DateTime CurrentTime { get; set; }
        public State State { get; set; }

        public Data[] ChildData { get; set; }
    }

    public enum State
    {
        Yes, No, Maybe
    }
}
